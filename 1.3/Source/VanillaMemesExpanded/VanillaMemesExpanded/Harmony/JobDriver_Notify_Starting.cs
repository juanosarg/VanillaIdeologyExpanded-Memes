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


    [HarmonyPatch(typeof(JobDriver))]
    [HarmonyPatch("Notify_Starting")]
    public static class VanillaMemesExpanded_JobDriver_Notify_Starting_Patch
    {
        [HarmonyPostfix]
        static void IfDumbSendHistoryEvent(JobDriver __instance)
        {

        
            if (__instance.job?.workGiverDef?.workType?.workTags.HasFlag(WorkTags.ManualDumb)==true)
            {
                
                Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_DumbLabor, new SignalArgs(__instance.pawn.Named(HistoryEventArgsNames.Doer))), true);

            }





        }
    }








}
