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


    [HarmonyPatch(typeof(TradeDeal))]
    [HarmonyPatch("TryExecute")]
    public static class VanillaMemesExpanded_TradeDeal_TruExecute_Patch
    {
        [HarmonyPostfix]
        static void NotifySuccessfulTrade(bool __result)
        {

           
                if (__result)
                {
                    PawnCollectionClass.ticksWithoutTrading = 0;
                }

            





        }
    }








}
