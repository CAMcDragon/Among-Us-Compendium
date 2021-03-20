using HarmonyLib;

namespace Compendium
{
  [HarmonyPatch(typeof(VersionShower), "Start"]
  public static class VersionShowerFix
  {
    public static void Postfix(VersionShower __instance)
    {
      __instance.text.Text += "\n\n\n\n\nLoaded Compendium !!!";
    }
  }
}
