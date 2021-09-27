using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Verse.AI;



namespace VanillaMemesExpanded
{


    [HarmonyPatch(typeof(Need_Joy))]
    [HarmonyPatch("GainJoy")]
    public static class VanillaMemesExpanded_Need_Joy_GainJoy_Patch
    {
        [HarmonyPostfix]
        static void InformJoyTakingPlace(Need_Joy __instance, Pawn ___pawn)
        {
            Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_HavingFun, ___pawn.Named(HistoryEventArgsNames.Doer)), true);





        }
    }








}
