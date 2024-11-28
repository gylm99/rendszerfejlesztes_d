using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using EstateSales.Backend.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertisementController : BaseController<Advertisement>
    {
        public AdvertisementController(IBaseRepo<Advertisement> repo) : base(repo)
        {
            
        }


         [HttpPost("CreateAdvertisement")]
         [Consumes("multipart/form-data")]
         public async Task<IActionResult> CreateAdvertisement(
                     [FromForm] string title,
                     [FromForm] double price,
                     [FromForm] double baseArea,
                     [FromForm] int roomNumber,
                     [FromForm] string description,
                     [FromForm] int builtYear,
                     [FromForm] string confort,
                     [FromForm] int floorLevel,
                     [FromForm] int mainBuildingFloorLevel,
                     [FromForm] bool hasElevator,
                     [FromForm] string orientation,
                     [FromForm] List<IFormFile> photos)
            { 

                Responsee responsee = new Responsee();
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                responsee.ClearAndAddError("A cím és/vagy leírás üresek.");
                return BadRequest(responsee);
            }

            
                Advertisement advertisement = new Advertisement
                {
                    Id = Guid.NewGuid(),
                    Title = title,
                    Price = price,
                    BaseArea = baseArea,
                    RoomNumber = roomNumber,
                    Description = description,
                    BuiltYear = builtYear,
                    Confort = confort,
                    FloorLevel = floorLevel,
                    MainBuildingFloorLevel = mainBuildingFloorLevel,
                    HasElevator = hasElevator,
                    Orientation = orientation
                };

           
                var advertisementFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", advertisement.Id.ToString());
                Directory.CreateDirectory(advertisementFolder);

          
                foreach (var photo in photos)
                {
                    if (photo.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
                        var filePath = Path.Combine(advertisementFolder, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(stream);
                        }

                   
                        advertisement.PhotosPath.Add($"/uploads/{advertisement.Id}/{fileName}");
                    }
                }

           
                await _repo.CreateAsync(advertisement);
           

                return Ok(responsee);
            }

    }
 }
