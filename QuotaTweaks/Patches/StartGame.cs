using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Unity.Netcode;
using UnityEngine;

namespace QuotaTweaks
{

  [HarmonyPatch(typeof(TimeOfDay))]

  public class TimeOfDayPatch
  {
    [HarmonyPatch("Awake")]
    [HarmonyPrefix]
    public static void UpdateQuota(ref TimeOfDay __instance)
    {
      var __quotaVariables = __instance.quotaVariables;

      __quotaVariables.startingQuota = ConfigManager.startingQuota.Value;
      __quotaVariables.baseIncrease = ConfigManager.quotaMinIncrease.Value;
      __quotaVariables.increaseSteepness = ConfigManager.quotaIncreaseSteepness.Value;
      __quotaVariables.randomizerMultiplier = ConfigManager.quotaRandomizerMultiplier.Value;
    }
  }


}