using HarmonyLib;

namespace Compendium.SheriffMod
{
  [HarmonyPatch(typeof(IntroCutscene.CoBegin__d), nameof(IntroCutscene.CoBegin__d.MoveNext))]
  public static class IntroCutsceneFix
  {
    public static void Postfix(IntroCutscene.CoBegin__d __instance)
    {
      if(!PlayerControl.LocalPlayer.isSheriff())
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
