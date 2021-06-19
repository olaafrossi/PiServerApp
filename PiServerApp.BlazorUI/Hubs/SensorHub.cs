using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PiServerApp.BlazorUI.Hubs
{
    public class SensorHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //await Clients.All.SendAsync("ReceiveMessage", user, message);
            await Clients.Others.SendAsync("ReceiveMessage", user, message + $"{DateTime.Now}");
        }
        public async Task SendInt(string user, int message)
        {
            //await Clients.All.SendAsync("ReceiveMessage", user, message);
            await Clients.Others.SendAsync("ReceiveInt" +
                                           "", user, message);
        }
    }
}
