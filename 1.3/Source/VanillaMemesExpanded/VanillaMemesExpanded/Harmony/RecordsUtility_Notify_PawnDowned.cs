﻿using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Verse.AI;



namespace VanillaMemesExpanded
{


    [HarmonyPatch(typeof(RecordsUtility))]
    [HarmonyPatch("Notify_PawnDowned")]
    public static class VanillaMemesExpanded_RecordsUtility_Notify_PawnDowned_Patch
    {
        [HarmonyPostfix]
        static void ThrowPawnDownedEvent(Pawn downed, Pawn instigator)
        {
            if (!instigator.NonHumanlikeOrWildMan()&&instigator.HostileTo(Faction.OfPlayer)) {
                Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_Defeat, downed.Named(HistoryEventArgsNames.Doer)), true);


            }



        }
    }








}
