using HarmonyLib;

namespace Compendium
{
  [HarmonyPatch(typeof(VersionShower), "Start"]
  public static VersionShowerFix
  {
    public static void Postfix(VersionShower __instance)
    {
      var text = __instance.text;
      text.Text += "[00FF00FF]Loaded[00FF00FF] Among Us Compendium v1.0.0 by [00FF00FF]CAMcDragon[00FF00FF]";
    }
  }
}
