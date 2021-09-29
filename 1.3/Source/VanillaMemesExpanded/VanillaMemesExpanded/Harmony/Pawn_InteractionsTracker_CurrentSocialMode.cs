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


    [HarmonyPatch(typeof(Pawn_InteractionsTracker))]
    [HarmonyPatch("CurrentSocialMode", MethodType.Getter)]
    public static class VanillaMemesExpanded_Pawn_InteractionsTracker_CurrentSocialMode_Patch
    {
        [HarmonyPostfix]
        static void DontInteract(Pawn ___pawn, ref RandomSocialMode __result)
        {
           if(___pawn.Ideo?.HasPrecept(InternalDefOf.VME_SocialInteractions_Disallowed) == true)
            {
                __result = RandomSocialMode.Off;
            }

        }
    }








}
