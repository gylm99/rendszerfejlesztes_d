﻿using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
using EstateSales.Backend.Repo.Base;
using EstateSales.Backend.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : BaseController<Message>
    {
        

            IMessageRepo _messageRepo;
            public MessageController(IBaseRepo<Message> repo, IMessageRepo messageRepo) : base(repo) { }

            [HttpPost("CreateMessage")]
            public async Task<IActionResult> CreateMessage(
                [FromForm] string senderEmailAddress,
                [FromForm] string content,
                [FromForm] Guid userId
                )
            {
                Responsee responsee = new Responsee();
                Message message = new Message
                {
                    SenderEmailAddress = senderEmailAddress,
                    Content = content,
                    UserId = userId
                };

                responsee = await _repo.CreateAsync(message);
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


        /*    [HttpGet("GetMessageByUser/{userId}")]
            public async Task<IActionResult> GetMessageByUser(Guid userId)
            {

                var messages = await _messageRepo.MessagesByUserAsync(userId);

                if (messages == null || !messages.Any())
                {
                    return BadRequest($"Nem talál {userId} felhasználóhoz hozzátartozó üzenet.");
                }
                else
                {
                    return Ok(messages);
                }
            }*/
    }
}
