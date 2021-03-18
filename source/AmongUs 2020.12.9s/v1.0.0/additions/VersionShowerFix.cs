using HarmonyLib;

namespace Compendium
{
  [HarmonyPatch(typeof(VersionShower), "Start"]
  public static class VersionShowerFix
  {
    public static Postfix(VersionShower __instance)
    {
      var text = __instance.text;
      text.Text += "\n[00FF00FF]Loaded Among Us Compendium by CAMcDragon[]";
    }
  }
}
