using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace YusanBlogger.Areas.DashboardAreas.ServicesHelpers
{
    public class ServicesHubs : Hub
    {
        public async Task GetConnection(string conn)
        {
            await Clients.All.SendAsync("", conn);
        }
    }
}
