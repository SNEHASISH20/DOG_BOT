using DOG_BOT.API.Interfaces;
using DOG_BOT.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOG_BOT.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpPost]
    public async Task<IActionResult> Chat(ChatRequest request)
    {
        var response = await _chatService.ChatAsync(request);

        return Ok(response);
    }
}