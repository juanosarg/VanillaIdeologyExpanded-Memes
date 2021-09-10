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


    [HarmonyPatch(typeof(DamageWorker_AddInjury))]
    [HarmonyPatch("Apply")]
    public static class VanillaMemesExpanded_DamageWorker_AddInjury_Apply_Patch
    {
        [HarmonyPostfix]
        static void DetectIfDamagedInnocent(DamageInfo dinfo, Thing thing)
        {
            Pawn instigatorPawn = dinfo.Instigator as Pawn;

            if (instigatorPawn!=null&&instigatorPawn.Ideo?.HasPrecept(InternalDefOf.VME_Violence_Abhorrent)==true) {

                Pawn victimPawn = thing as Pawn;
                
                if (victimPawn != null && !victimPawn.HostileTo(instigatorPawn) && victimPawn.RaceProps.Humanlike)
                {
                    
                    Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_AttackedInnocent, dinfo.Instigator.Named(HistoryEventArgsNames.Doer)), true);

                }


            }
            





        }
    }








}
