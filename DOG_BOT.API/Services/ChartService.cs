using DOG_BOT.API.Models;
using DOG_BOT.API.Interfaces;
using System.Threading.Tasks;

namespace DOG_BOT.API.Services;


public class ChatService : IChatService
{
    public Task<ChatResponse> ChatAsync(ChatRequest request){
        
        var response = new ChatResponse();

        if(request.request_message != ""){
            response = new ChatResponse{
                response_message = "You Said : " + request.request_message
            };
        }

        return Task.FromResult(response);
    }
}