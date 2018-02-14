using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Id
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();
        

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "MzQ1NzY2MzI3MzIxMTAwMjg5.DWBuFg.-MBzApgw6pRLh-6gHrDvvFBFvp8");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}