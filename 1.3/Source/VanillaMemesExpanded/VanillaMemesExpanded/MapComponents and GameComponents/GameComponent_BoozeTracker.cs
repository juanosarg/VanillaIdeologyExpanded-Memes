using System;
using RimWorld;
using Verse;
using RimWorld.Planet;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class GameComponent_BoozeTracker : GameComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 15000;
        public int ticksWithoutADrink;
        public Dictionary<Pawn, int> colonist_booze_tracker_backup = new Dictionary<Pawn, int>();
        List<Pawn> list2;
        List<int> list3;


        public GameComponent_BoozeTracker(Game game) : base()
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


        public override void GameComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {

                
                    colonist_booze_tracker_backup = PawnCollectionClass.colonist_booze_tracker;

                    foreach (Pawn p in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists)
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
