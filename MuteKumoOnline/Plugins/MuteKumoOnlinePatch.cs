using HarmonyLib;
using Scripts.OutGame.OnlineRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuteKumoOnline.Plugins
{
    internal class MuteKumoOnlinePatch
    {
        [HarmonyPatch(typeof(OnlineRoomSoundController))]
        [HarmonyPatch(nameof(OnlineRoomSoundController.PlayJoinLobbyRandomVoice))]
        [HarmonyPatch(MethodType.Normal)]
        [HarmonyPrefix]
        public static bool OnlineRoomSoundController_PlayJoinLobbyRandomVoice_Prefix()
        {
            Logger.Log("OnlineRoomSoundController_PlayJoinLobbyRandomVoice_Prefix");

            return false;
        }
    }
}
