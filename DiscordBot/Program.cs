using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordBot
{
  internal class Program
  {
    public static void Main(string[] args)
    => new Program().MainAsync().GetAwaiter().GetResult();

    public async Task MainAsync()
    {
      
    }
    private Task Log(LogMessage msg)
    {
      Console.WriteLine(msg.ToString());
      return Task.CompletedTask;
    }
  }
}