namespace RespawnTimer.Configs
{
    using System.Collections.Generic;
    using System.ComponentModel;

#if EXILED
    public sealed class Config : Exiled.API.Interfaces.IConfig
#else
    public sealed class Config
#endif
    {
        [Description("是否啟用插件。")]
        public bool IsEnabled { get; set; } = true;

        [Description("是否在伺服器控制台中顯示除錯訊息。")]
        public bool Debug { get; set; } = false;

        public Dictionary<string, string> Timers { get; private set; } = new()
        {
            {
                "default", "ExampleTimer"
            },
        };

        [Description("是否每回合重新載入計時器。如果您設計了許多不同的計時器，這將非常有用。")]
        public bool ReloadTimerEachRound { get; private set; } = true;

        [Description("是否對監視狀態下的玩家隱藏計時器。")]
        public bool HideTimerForOverwatch { get; private set; } = true;

        [Description("在玩家死亡後顯示計時器之前的延遲時間。")]
        public float TimerDelay { get; private set; } = -1;
    }
}
