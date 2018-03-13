using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalRChat.StartupChat))]
namespace SignalRChat
{
   public class StartupChat 
   {
      public void Configuration(IAppBuilder app)
      {
         // Any connection or hub wire up and configuration should go here
         app.MapSignalR();
      }
   }
}