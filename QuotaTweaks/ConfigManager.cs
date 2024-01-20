using BepInEx.Configuration;

namespace QuotaTweaks
{

  public class ConfigManager
  {

    public static ConfigManager Instance { get; private set; }
    public static void Init(ConfigFile config)
    {
      Instance = new ConfigManager(config);
    }

    public static ConfigEntry<int> startingQuota { get; private set; }
    public static ConfigEntry<int> quotaMinIncrease { get; private set; }
    public static ConfigEntry<float> quotaIncreaseSteepness { get; private set; }
    public static ConfigEntry<float> quotaRandomizerMultiplier { get; private set; }

    private ConfigManager(ConfigFile config)
    {
      startingQuota = config.Bind("Settings", "Starting Quota", 250, "The starting quota for the game.");
      quotaMinIncrease = config.Bind("Settings", "Quota Min Increase", 300, "The minimum amount of quota increase.");
      quotaIncreaseSteepness = config.Bind("Settings", "Quota Increase Steepness", 4f, "The steepness of the quota increase curve - higher value means a less steep exponential increase.");
      quotaRandomizerMultiplier = config.Bind("Settings", "Quota Randomizer Multiplier", 1f, "The multiplier for the quota randomizer - this determines the severity of the randomizer curve.");
    }

  }
}