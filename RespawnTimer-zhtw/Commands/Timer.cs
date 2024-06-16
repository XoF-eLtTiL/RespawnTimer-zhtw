namespace RespawnTimer.Commands
{
    using CommandSystem;
    using System;
#if EXILED
    using Exiled.API.Features;
#else
    using PluginAPI.Core;
#endif

    using static API.API;

    [CommandHandler(typeof(ClientCommandHandler))]
    public class Timer : ICommand
    {
        public string Command => "timer";

        public string[] Aliases => Array.Empty<string>();

        public string Description => "Shows / hides RespawnTimer.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            string userId = Player.Get(sender).UserId;

            if (!TimerHidden.Remove(userId))
            {
                TimerHidden.Add(userId);

                response = "<color=red>重生時間介面已隱藏!</color>";
                return true;
            }

            response = "<color=green>重生時間介面已顯示!</color>";
            return true;
        }
    }
}