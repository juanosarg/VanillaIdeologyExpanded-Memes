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


    [HarmonyPatch(typeof(TaleUtility))]
    [HarmonyPatch("Notify_PawnDied")]
    public static class VanillaMemesExpanded_TaleUtility_Notify_PawnDied_Patch
    {
        [HarmonyPostfix]
        static void NotifyIfEnemyDiedToFire(Pawn victim, DamageInfo? dinfo)
        {


            if (victim?.Faction?.HostileTo(Faction.OfPlayerSilentFail)==true&&victim?.IsBurning()==true) {

                Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_KillingWithFire));

            }




        }
            





        }
    }









