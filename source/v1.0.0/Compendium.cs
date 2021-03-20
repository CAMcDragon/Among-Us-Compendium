using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.IL2CPP;
using Essentials.Options;
using HarmonyLib;
using Reactor;
using Reactor.Extensions;
using Reactor.Unstrip
using Compendium.RainbowSkin;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace Compendium
{
  [BepInPlugin("com.camcdragon.amonguscompendium", "Among Us Compendium", "1.0.0")]
  [BepInDependency(ReactorPlugin.Id)]
  public class Compendium : BasePlugin
  {
    // Captain
    public static readonly CustomToggleOption IncludeCaptain = CustomGameOptions.AddToggle("Include Captain", false);
    
    if(IncludeCaptain)
    {
      public static readonly CustomToggleOption CaptainBankCountLimitExists = CustomGameOptions.AddToggle("Captain has Max-Vote Pool Limit", false);
      
      if(CaptianBankCountLimitExists)
      {
        public static readonly CustomNumberOption CaptainMaxBankCount = CustomGameOptions.AddNumber("Captain Max Bank Count", 1, 1, 1, 10, 1);
      }
      
      public static readonly CustomToggleOption CaptainCanFixSabotage = false;
    }
    
    // Coward
    public static readonly CustomToggleOption IncludeCoward = CustomGameOptions.AddToggle("Include Coward", false);
    
    if(IncludeCoward)
    {
      public static readonly CustomToggleOption IncludeCoward
      public static readonly CustomToggleOption CowardCanEnterVents = CustomGameOptions.AddToggle("Coward Can Enter Vents", true);
      
      if(CowardCanEnterVents)
      {
        public static readonly CustomToggleOption CowardCanDieInVent = CustomGameOptions.AddToggle("Coward Can Die in Vents", true);
      }
      
      public static readonly CustomToggleOption CowardCanFixSabotage = CustomGameOptions.AddToggle("Coward Can Fix Sabotage", false);
    }
    
    // Hacker
    public static readonly CustomToggleOption IncludeHacker = CustomGameOptions.AddToggle("Include Hacker", false);
    
    if(IncludeHacker)
    {
      public static readonly CustomToggleOption HackerCanRemotelyFixSabotage = CustomGameOptions.AddToggle("Hacker Can Remotely Fix Sabotage", true;
      public static readonly CustomToggleOption HackerCanCauseSabotage = CustomGameOptions.AddToggle("Hacker Can Sabotage", true);
    }
    
    // Jester
    public static readonly CustomToggleOption IncludeJester = CustomGameOptions.AddToggle("Include Jester", false);
    
    // Lovers
    public static readonly CustomToggleOption IncludeLovers = CustomGameOptions.AddToggle("Include Lovers", false);
    
    if(IncludeLovers)
    {
      public static readonly CustomToggleOption CanHaveLoverImpostor = CustomGameOptions.AddToggle("Can Have Loving Impostor", true);
      public static readonly CustomToggleOption LoversDieTogether = CustomGameOptions.AddToggle("Lovers Die Together", true);
      public static readonly CustomToggleOption PartnerDiesOnDisconnect = CustomGameOptions.AddToggle("Partner Dies on Disconnect", false);
      public static readonly CustomToggleOption LoversCanShareTasks = CustomGameOptions.AddToggle("Lovers Can Share Tasks", false);
    }
    
    // Sheriff
    public static readonly CustomToggleOption IncludeSheriff = CustomGameOptions.AddToggle("Include Sheriff", false);
    
    if(IncludeSheriff)
    {
      public static readonly CustomToggleOption RevealSheriff = CustomGameOptions.AddToggle("Reveal Sheriff", false);
      public static readonly CustomNumberOption SheriffKillCooldown = CustomGameOptions.AddNumber("Sheriff Kill Cooldown", 25f, 10f, 40f, 2.5f);
    }
  }
}
