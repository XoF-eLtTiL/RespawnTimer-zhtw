namespace RespawnTimer.Configs
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public sealed class Properties
    {
        [Description("如果分鐘和秒數小於10，是否應該添加前導零。")]
        public bool LeadingZeros { get; private set; } = true;

        [Description("計時器是否應根據MTF/CI的重生添加時間偏移。")]
        public bool TimerOffset { get; private set; } = true;

        [Description("自訂提示應更改的頻率（以秒為單位）。")]
        public int HintInterval { get; private set; } = 10;

        [Description("九尾狐的顯示名稱。")]
        public string Ntf { get; private set; } = "<color=blue>九尾狐</color>";

        [Description("混沌分裂者的顯示名稱。")]
        public string Ci { get; private set; } = "<color=green>混沌分裂者</color>";

        [Description("蛇之手的顯示名稱。")]
        public string Sh { get; private set; } = "<color=red>蛇之手</color>";

        [Description("異常事件處理局的顯示名稱。")]
        public string Uiu { get; private set; } = "<color=yellow>異常事件處理局</color>";

        [Description("核彈狀態的顯示名稱：")]
#if EXILED
        public Dictionary<Exiled.API.Enums.WarheadStatus, string> WarheadStatus { get; private set; } = new()
        {
            {
                Exiled.API.Enums.WarheadStatus.NotArmed, "<color=green>未啟動</color>"
            },
            {
                Exiled.API.Enums.WarheadStatus.Armed, "<color=orange>已啟動</color>"
            },
            {
                Exiled.API.Enums.WarheadStatus.InProgress, "<color=red>執行中 - </color> {detonation_time} 秒"
            },
            {
                Exiled.API.Enums.WarheadStatus.Detonated, "<color=#640000>已引爆</color>"
            },
        };
#else
        public Dictionary<string, string> WarheadStatus { get; private set; } = new()
        {
            {
                "NotArmed", "<color=green>未啟動</color>"
            },
            {
                "Armed", "<color=orange>已啟動</color>"
            },
            {
                "InProgress", "<color=red>執行中 - </color> {detonation_time} 秒"
            },
            {
                "Detonated", "<color=#640000>已引爆</color>"
            },
        };
#endif
    }
}
