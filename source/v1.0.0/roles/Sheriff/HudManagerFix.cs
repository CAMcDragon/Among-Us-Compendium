using HarmonyLib;
using System;

namespace Compendium.SheriffMod
{
  [HarmonyPatch(typeof(HudManager))]
  public static class HudManagerFix
  {
    public static HudManager HUD;
    public static KillButtonManager KillButton;
    
    public static void UpdateMeetingHUD(MeetingHud __instance)
    {
      foreach(var player in __instance.playerStates)
      {
        if(player.NameText.Text == Sheriff.instance.parent.playerdata.name && CustomGameOptions.IncludeSheriff)
        {
          if(PlayerControl.LocalPlayer.isSheriff() || CustomGameOptions.RevealSheriff)
          {
            player.NameText.Color = Sheriff.color;
          }
        }
      }
    }
    
    public static void Postfix(HudManager __instance)
    {
      HUD = __instance;
      KillButton = __instance.KillButton;
      
      PlayerController.Update();
      
      if(MeetingHud.Instance != null)
      {
        UpdateMeetingHUD(MeetingHud.Instance);
      }
    }
  }
}
