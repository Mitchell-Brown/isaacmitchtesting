using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace Id.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {

        [Command("Test")]
        public async Task skdfjasdkjf()
        {
            await Context.Channel.SendMessageAsync("Your actions have been recorded in the eternal book.");
        }

        [Command("user")]
        public async Task test2lol(IGuildUser user) => await Context.Channel.SendMessageAsync(user.ToString());

        [Command("roll")]
        public async Task rollstuff(int1 int2)
        {
            await Context.Channel.SendMessageAsync("Rolling " + int1.toString + "d " + int2.toString);
        }
    }
}
