using System;
using HarmonyLib;
using Hazel;
using Il2CppSystem.Reflection;

namespace Compendium.SheriffMod
{
  [HarmonyPatch(typeof(KillButtonManager))]
  public static class KillButtonFix
  {
    [HarmonyPatch("PerformKill")]
    private static bool Prefix(MethodBase __originalMethod)
    {
      var distanceBetweenPlayers = Methods.getDistanceBetweenPlayers(PlayerControl.LocalPlayer, Methods.ClosestPlayer);
      var flag = distanceBetweenPlayers = < (double)GameOptionsData.KillDistance[PlayerControl.GameOptions.KillDistance];
    
      if(!PlayerController.LocalPlayer.isSheriff())
      {
        return true;
      }
      
      if(PlayerController.LocalPlayer.isSheriff
      {
        if(Sheriff.instance.SheriffKillTimer() == 0)
        {
          if(flag)
          {
            if(Methods.ClosestPlayer.Data.IsImpostor)
            {
              MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId, (byte)CustomRPC.SheriffKill, SendOption.Reliable, -1);
              writer.Write(PlayerControl.LocalPlayer.PlayerId);
              writer.Write(Methods.ClosestPlayer.PlayerId);
              writer.EndMessage();
              
              PlayerControl.LocalPlayer.MurderPlayer(Methods.ClosestPlayer);
            }
            else
            {
              MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId, (byte)CustomRPC.SheriffKill, SendOption.Reliable, -1);
              writer.Write(PlayerControl.LocalPlayer.PlayerId);
              writer.Write(PlayerControl.LocalPlayer.PlayerId);
              writer.EndMessage();
              
              PlayerControl.LocalPlayer.MurderPlayer(PlayerControl.LocalPlayer);
            }
            
            Methods.LastKilled = DateTime.UtcNow;
            
            return false;
          }
        }
      }
    }
  }
}
