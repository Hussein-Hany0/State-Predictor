using GraduationProject.App.Models;
using Microsoft.AspNetCore.SignalR;
using GraduationProject.App.ViewModels;
using Newtonsoft.Json;

namespace GraduationProject.App.Hubs
{
    public class PredictionHub : Hub
    {
        public void PushMindState(string stringMindStateViewModel)
        {
            MindStateViewModel mindStateViewModel = JsonConvert.DeserializeObject<MindStateViewModel>(stringMindStateViewModel);

            Clients.All.SendAsync("PullMindState", mindStateViewModel);
        }
    }
}
