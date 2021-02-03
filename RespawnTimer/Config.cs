﻿using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace RespawnTimer
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Should debug messages be shown in a server console?")]
        public bool ShowDebugMessages { get; set; } = false;
        [Description("How often (in seconds) should timer be refreshed?")]
        public float Interval { get; set; } = 1f;

        [Description("Should a timer be lower or higher on the screen? (values from 0 to 14, 0 - very high, 14 - very low)")]
        public byte TextLowering { get; set; } = 8;


        [Description("Should a timer show an exact number of minutes?")]
        public bool ShowMinutes { get; set; } = true;

        [Description("Should a timer show an exact number of seconds?")]
        public bool ShowSeconds { get; set; } = true;


        [Description("Should a timer be only shown, when a spawnning sequence has begun? (NTF Helicopter / Chaos Car arrives)")]
        public bool ShowTimerOnlyOnSpawn { get; set; } = false;

        [Description("Should number of spectators be shown?")]
        public bool ShowNumberOfSpectators { get; set; } = true;

        [Description("Should the NTF and CI respawn tickets be shown?")]
        public bool ShowTickets { get; set; } = true;

        [Description("Translations: (do NOT change text in { }, you can for example bold them)")]
        public string YouWillRespawnIn { get; set; } = "<color=orange>You will respawn in: </color>";
        public string YouWillSpawnAs { get; set; } = "You will spawn as: ";
        public string Ntf { get; set; } = "<color=blue>Nine-Tailed Fox</color>";
        public string Ci { get; set; } = "<color=green>Chaos Insurgency</color>";
        public string Sh { get; set; } = "<color=red>Serpent's Hand</color>";
        public string Uiu { get; set; } = "<color=#1078e0>Unusual Incidents Unit</color>";
        public string Spectators { get; set; } = "<color=#B3B6B7>Spectators: </color>";
        public string NtfTickets { get; set; } = "<color=blue>NTF Tickets: </color>";
        public string CiTickets { get; set; } = "<color=green>CI Tickets: </color>";
        public string Seconds { get; set; } = " <b>{seconds} s</b>";
        public string Minutes { get; set; } = "<b>{minutes} min.</b>";
        public string SpectatorsNum { get; set; } = "{spectators_num}";
        public string NtfTicketsNum { get; set; } = "{ntf_tickets_num}";
        public string CiTicketsNum { get; set; } = "{ci_tickets_num}";
    }
}