using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_FireTracker : MapComponent
    {



        public int tickCounter = 0;
        public int tickInterval = 2000;
        public int firesInTheMap_backup = 0; 


        public MapComponent_FireTracker(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.firesInTheMap = firesInTheMap_backup;

            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<int>(ref this.firesInTheMap_backup, "firesInTheMap_backup", 0, true);

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterFire", 0, true);

        }
        public override void MapComponentTick()
        {


            tickCounter++;
            if ((tickCounter > tickInterval))
            {




                firesInTheMap_backup = PawnCollectionClass.firesInTheMap;                

                int wildFires = map.listerThings.ThingsOfDef(ThingDefOf.Fire).Count;
                int campFires = map.listerThings.ThingsOfDef(ThingDefOf.Campfire).Count;
                int stoneCampfires = 0;
                if (DefDatabase<ThingDef>.GetNamedSilentFail("Stone_Campfire") != null) {
                    stoneCampfires = map.listerThings.ThingsOfDef(DefDatabase<ThingDef>.GetNamedSilentFail("Stone_Campfire")).Count;
                }
                int braziers = 0;
                if (DefDatabase<ThingDef>.GetNamedSilentFail("Brazier") != null)
                {
                    braziers = map.listerThings.ThingsOfDef(DefDatabase<ThingDef>.GetNamedSilentFail("Brazier")).Count;
                }
                firesInTheMap_backup = wildFires + campFires + stoneCampfires + braziers;
                PawnCollectionClass.firesInTheMap = firesInTheMap_backup;


                tickCounter = 0;
            }



        }
       



    }


}



