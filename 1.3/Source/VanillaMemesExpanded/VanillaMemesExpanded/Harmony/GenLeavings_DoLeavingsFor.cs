using HarmonyLib;
using RimWorld;
using Verse;
using System;
using System.Collections.Generic;




namespace VanillaMemesExpanded
{
    /*

    [HarmonyPatch(typeof(GenLeaving))]
    [HarmonyPatch("DoLeavingsFor")]
    [HarmonyPatch(new Type[] { typeof(Thing), typeof(Map), typeof(DestroyMode), typeof(CellRect), typeof(Predicate<IntVec3>), typeof(List<Thing>) })]

   
    public static class VanillaMemesExpanded_GenLeaving_DoLeavingsFor_Patch
    {
        [HarmonyPostfix]
        static void IfDefModExtensionAndScrapperDropExtra(Thing diedThing, Map map)
        {
            if(Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo.HasPrecept(InternalDefOf.VME_JunkDeconstructionYield_High)) {

                if (diedThing.def.HasModExtension<JunkDeconstructionItems>())
                {
                    List<ThingDefCountClass> list = diedThing.def.GetModExtension<JunkDeconstructionItems>().deconstructionItems;

                    for (int k = 0; k < list.Count; k++)
                    {
                        Thing thing = ThingMaker.MakeThing(list[k].thingDef, null);
                        thing.stackCount = list[k].count;
                        GenSpawn.Spawn(thing, CellFinder.RandomClosewalkCellNear(diedThing.Position, map, 2, null), map, WipeMode.Vanish);
                    }




                }

            }





        }
    }



    */




}
