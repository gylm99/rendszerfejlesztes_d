using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
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
        IPhotoRepo _photoRepo;
        IAdvertisementRepo _advertisementRepo;
        public AdvertisementController(IBaseRepo<Advertisement> repo, IPhotoRepo photoRepo, IAdvertisementRepo advertisementRepo) : base(repo)
        {
            _photoRepo = photoRepo ?? throw new ArgumentException($"{photoRepo}");
            _advertisementRepo = advertisementRepo ?? throw new ArgumentException($"{advertisementRepo}");
        }

        


         [HttpPost("CreateAdvertisement")]
         [Consumes("multipart/form-data")]
         public async Task<IActionResult> CreateAdvertisement(
                     [FromForm] Guid userId,
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
                    UserId = userId,
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



                    Photo newPhoto = new Photo( $"/uploads/{advertisement.Id}/{fileName}",advertisement.Id);
                    responsee = await _photoRepo.CreatePhotoAsync(newPhoto);
                }
            }
           
               responsee= await _repo.CreateAsync(advertisement);
            if (responsee.HasError)
            {
                Console.WriteLine(responsee.Error);
            }
            else
            {
                return Ok(responsee);
            }

            responsee.ClearAndAddError("Az új adatok mentése nem lehetséges");
           return BadRequest(responsee);
            }






            [HttpGet("GetByIdWithPhotos/{advertisementId}")]
            public async Task<IActionResult> GetAdvertisementWithPhotos(Guid advertisementId)
            {
            
                var advertisement = await _advertisementRepo.GetAdvertisementWithPhotosAsync(advertisementId);

                if (advertisement == null)
                {
                    return NotFound($"A hirdetés {advertisementId} ID-val nem található.");
                }

                return Ok(advertisement);
            }


        [HttpGet("photos/count")]
        public async Task<IActionResult> GetTotalPhotoCount()
        {
            var totalPhotoCount = await _photoRepo.GetTotalPhotoCountAsync();
            return Ok(new { TotalPhotos = totalPhotoCount });
        }






    }
 }
