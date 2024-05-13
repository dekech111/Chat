using Microsoft.AspNetCore.SignalR;

namespace ChatServer.Areas.Chat.Habs
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string username)
        {
            await Clients.All.SendAsync("Receive", message, username);
        }
    }
}
