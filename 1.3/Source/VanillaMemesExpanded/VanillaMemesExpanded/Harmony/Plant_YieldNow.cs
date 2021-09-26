using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Verse.AI;



namespace VanillaMemesExpanded
{
   

    [HarmonyPatch(typeof(Plant))]
    [HarmonyPatch("YieldNow")]
    public static class VanillaMemesExpanded_Plant_YieldNow_Patch
    {
        [HarmonyPostfix]
        static void IncreaseTreeCuttingYield(Plant __instance,ref int __result)
        {
            if ((__instance.def.plant.IsTree && Current.Game.World.factionManager.OfPlayer.ideos.GetPrecept(InternalDefOf.VME_WoodcuttingYield_High)!=null)||
                (__instance.IsCrop && Current.Game.World.factionManager.OfPlayer.ideos.GetPrecept(InternalDefOf.VME_FarmingYield_High) != null))
            {
                __result = GenMath.RoundRandom(__result* 1.1f);

            }

         



        }
    }








}
