using HarmonyLib;
using UnityEngine;

namespace Compendium
{
  [HarmonyPatch(typeof(IntroCutscene.CoBegin__d))]
  public static class Intro
  {
    var localplayer = PlayerController.GetLocalPlayer();
  
    [HarmonyPatch("MoveNext")]
    public static bool Prefix(IntroCutscene.CoBegin__d __instance)
    {
      if(!localplayer.IsLover() || !localplayer.IsJoker() || !localplayer.IsCoward())
      {
        return true;
      }
      
      var CowardTeam = new List<PlayerControl>();
      var JokerTeam = new List<PlayerControl>();
      var LoverTeam = new List<PlayerControl>();
      
      if(localplayer.IsCoward())
      {
        CowardTeam.Add(localplayer);
        __instance.yourTeam = CowardTeam;
      }
      else if(localplayer.IsJoker())
      {
        JokerTeam.Add(localplayer);
        __instance.yourTeam = JokerTeam;
      }
      else if(localplayer.IsLover())
      {
        LoverTeam.Add(localplayer);
        LoverTeam.Add(localplayer.OtherLover());
        __instance.yourTeam = LoverTeam;
      }
      
      return true;
    }
    
    [HarmonyPatch("MoveNext")]
    public static void Postfix(IntroCutscene.CoBegin__d __instance)
    {

      if(localplayer == null)
      {
        return;
      }

      if(localplayer.IsCaptain())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Captain";
        __instance.__this.Title.Color = Captain.color;
        __instance.__this.ImpostorText.Text = "Save your votes to double vote";
        __instance.__this.BackgroundBar.material.color = Captain.color;
      }
      else if(localplayer.IsCoward())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Coward";
        __instance.__this.Title.Color = Coward.color;
        __instance.__this.ImpostorText.Text = "Survive at all costs";
        __instance.__this.BackgroundBar.material.color = Coward.color;
      }
      else if(localplayer.IsHacker())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Hacker";
        __instance.__this.Title.Color = Hacker.color;
        __instance.__this.ImpostorText.Text = "Use sabotages to your advantage";
        __instance.__this.BackgroundBar.material.color = Hacker.color;
      }
      else if(localplayer.IsJester())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Jester";
        __instance.__this.Title.Color = Jester.color;
        __instance.__this.ImpostorText.Text = "Get voted out";
        __instance.__this.BackgroundBar.material.color = Jester.color;
      }
      else if(localplayer.IsLover())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Lover";

        if(localplayer.Data.IsImpostor)
        {
          __instance.__this.Title.Text = "Loving Impostor";
          __instance.__this.Title.scale /= 2.3f;
        }

        __instance.__this.Title.Color = Lover.color;
        __instance.__this.ImpostorText.Text = "You are in [FF66CCFF]Love [FFFFFFFF]with [FF66CCFF]" + localplayer.OtherLover().name;
        __instance.__this.BackgroundBar.material.color = Lover.color;
      }
      else if(localplayer.IsSheriff())
      {
        if(__instance.__this == null)
        {
          return;
        }

        __instance.__this.Title.Text = "Sheriff";
        __instance.__this.Title.Color = Sheriff.color;
        __instance.__this.ImpostorText.Text = "Shoot the [FF0000FF]Impostor";
        __instance.__this.BackgroundBar.material.color = Sheriff.color;
      }
    }
  }
}
