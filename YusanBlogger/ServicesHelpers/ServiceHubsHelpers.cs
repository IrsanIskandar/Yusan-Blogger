using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace YusanBlogger.ServicesHelpers
{
    public class ServiceHubsHelpers : Hub
    {
        public async Task GetConnection(string conn)
        {
            await Clients.All.SendAsync("", conn);
        }
    }
}
