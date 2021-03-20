namespace Compendium
{
  public static class CustomGameOptions
  {
    // Captain
    public static bool IncludeCaptain = false;
    public static bool CaptainBankCountLimitExists = false;
    public static int CaptainMaxBankCount = 10;
    public static bool CaptainCanFixSabotage = false;
    
    // Coward
    public static bool IncludeCoward = false;
    public static bool CowardCanEnterVents = true;
    public static bool CowardCanDieInVent = true;
    public static bool CowardCanFixSabotage = false;
    
    // Hacker
    public static bool IncludeHacker = false;
    public static bool HackerCanRemotelyFixSabotage = true;
    public static bool HackerCanCauseSabotage = true;
    
    // Jester
    public static bool IncludeJester = false;
    
    // Lovers
    public static bool IncludeLovers = false;
    public static bool LoversDieTogether = true;
    public static bool PartnerDiesOnDisconnect = false;
    public static bool LoversCanShareTasks = false;
    
    // Sheriff
    public static bool IncludeSheriff = false;
    public static bool RevealSheriff = false;
    public static float SheriffKillCooldown = 25.0f;
  }
}
