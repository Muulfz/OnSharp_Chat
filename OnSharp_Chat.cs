using Onsharp.Entities;
using Onsharp.Events;
using Onsharp.Plugins;
using System;

namespace OnSharp_Chat
{

    [PluginMeta("onsharp-chat", "Chat Plugin", "1.0", "Codeskull", IsDebug = true)]
    public class OnSharp_Chat : Plugin
    {

        public override void OnStart() { }
        public override void OnStop() { }

        [ServerEvent(EventType.PlayerChat)]
        public void OnChat(Player player, string text)
        {
            var hourMinutesec = DateTime.Now.ToString("HH:mm:ss");
            foreach (var pl in Server.Players)
            {
                pl.SendMessage("<span color=\"#2397e7\" size=\"10\">["+ hourMinutesec + "]</> <span color=\"#e7a523\" size=\"10\">" + pl.Name + " :</> <span color=\"#ffffff\" size=\"10\">" + text + "</>");
            } 
        }

    }

}