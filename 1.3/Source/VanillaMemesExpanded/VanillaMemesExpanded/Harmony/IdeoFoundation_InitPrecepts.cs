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


    [HarmonyPatch(typeof(IdeoFoundation))]
    [HarmonyPatch("InitPrecepts")]
    public static class VanillaMemesExpanded_IdeoFoundation_InitPrecepts_Patch
    {
        [HarmonyPostfix]
        public static void SetMaxToOptions(ref IntRange ___MemeCountRangeAbsolute)
        {


            ___MemeCountRangeAbsolute = new IntRange(1, (int)VanillaMemesExpanded_Settings.memeAmount);


        }
    }








}
