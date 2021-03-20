using HarmonyLib;

namespace Compendium
{
  [HarmonyPatch(typeof(VersionShower), "Start")]
  public static class VersionShowerFix
  {
  __instance.text.Text += "\n[00FF00FF]Loaded Among Us Compendium by CAMcDragon[00FF00FF]";
  }
}
