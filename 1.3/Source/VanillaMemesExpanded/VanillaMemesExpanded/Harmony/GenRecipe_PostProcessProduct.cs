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


    [HarmonyPatch(typeof(GenRecipe))]
    [HarmonyPatch("PostProcessProduct")]
    public static class VanillaMemesExpanded_GenRecipe_PostProcessProduct_Patch
    {
        [HarmonyPostfix]
        static void IncreaseQualityByOne(Thing product, RecipeDef recipeDef, Pawn worker)
        {

            if (worker.Ideo.HasPrecept(InternalDefOf.VME_CraftingQuality_Increased)) {

                CompQuality compQuality = product.TryGetComp<CompQuality>();
                if (compQuality != null)
                {
                    if (recipeDef.workSkill == null)
                    {
                        Log.Error(recipeDef + " needs workSkill because it creates a product with a quality.");
                    }
                    if (compQuality.Quality != QualityCategory.Legendary) {
                        compQuality.SetQuality(compQuality.Quality + 1, ArtGenerationContext.Colony);

                    }

                }

            }





        }
    }








}
