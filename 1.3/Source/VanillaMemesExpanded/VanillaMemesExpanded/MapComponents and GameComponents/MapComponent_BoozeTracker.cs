using System;
using RimWorld;
using Verse;
using RimWorld.Planet;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_BoozeTracker : MapComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 15000;
        public int ticksWithoutADrink;
        public Dictionary<Pawn, int> colonist_booze_tracker_backup = new Dictionary<Pawn, int>();
        List<Pawn> list2;
        List<int> list3;


        public MapComponent_BoozeTracker(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {
           
            PawnCollectionClass.colonist_booze_tracker = colonist_booze_tracker_backup;


            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterBooze", 0, true);        
            Scribe_Collections.Look(ref colonist_booze_tracker_backup, "colonist_booze_tracker_backup", LookMode.Reference, LookMode.Value, ref list2, ref list3);
        }


        public override void MapComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                colonist_booze_tracker_backup = PawnCollectionClass.colonist_booze_tracker;

                foreach (Pawn p in map.mapPawns.FreeColonistsSpawned)
                {
                    PawnCollectionClass.AddColonistToBoozeList(p, 0);
                    
                        if (PawnCollectionClass.colonist_booze_tracker[p] < int.MaxValue - tickInterval)
                        {
                            PawnCollectionClass.IncreasePawnBoozeTicks(p, tickInterval);

                        }
                    


                }





                tickCounter = 0;
            }



        }


    }


}
