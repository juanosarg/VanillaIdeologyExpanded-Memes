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


    [HarmonyPatch(typeof(ThoughtWorker_Sick))]
    [HarmonyPatch("CurrentStateInternal")]
    public static class VanillaMemesExpanded_ThoughtWorker_Sick_CurrentStateInternal_Patch
    {
        [HarmonyPostfix]
        static void DontShowIfHolyDisease(Pawn p, ref ThoughtState __result)
        {
            if (p.Ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted)||p.Ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted))
            {
                __result = false;
            }





        }
    }








}
