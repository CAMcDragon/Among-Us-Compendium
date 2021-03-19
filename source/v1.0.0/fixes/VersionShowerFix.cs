using HarmonyLib;

namespace Compendium
{
  [HarmonyPatch(typeof(VersionShower), "Start")]
  public static class VersionShower
  {
    var text = __instance.text;
    text.Text += "\n[00FF00FF]Loaded Compendium v1.0.0 by CAMcDragon[]"
  }
}
