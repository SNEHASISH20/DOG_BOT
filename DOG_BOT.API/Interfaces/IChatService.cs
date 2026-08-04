using DOG_BOT.API.Models;

namespace DOG_BOT.API.Interfaces;


public interface IChatService{
   Task<ChatResponse> ChatAsync(ChatRequest request);
}