using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace RezeroDiscord.Modules
{
    public interface Main : IDisposable
    {
        public class one : ModuleBase<SocketCommandContext>
        {
            public static DiscordSocketClient client;
            public static BaseSocketClient socket;
            
            [Command("ping")]
            public async Task Echo()
            {
                var ping = Context.Client.Latency;
                await ReplyAsync(ping.ToString());
            }
        }
    }
}
