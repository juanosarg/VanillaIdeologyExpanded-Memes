using System;
using RimWorld;
using Verse;
using RimWorld.Planet;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class GameComponent_ColonistScarCounter : GameComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 20000;
        public Dictionary<Pawn, int> colonist_scar_counter_backup = new Dictionary<Pawn, int>();
        List<Pawn> list2;
        List<int> list3;


        public GameComponent_ColonistScarCounter(Game game) : base()
        {

        }

        public override void FinalizeInit()
        {
           
            PawnCollectionClass.colonist_scar_counter = colonist_scar_counter_backup;


            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterScars", 0, true);
            Scribe_Collections.Look(ref colonist_scar_counter_backup, "colonist_scar_counter_backup", LookMode.Reference, LookMode.Value, ref list2, ref list3);



        }


        public override void GameComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                colonist_scar_counter_backup = PawnCollectionClass.colonist_scar_counter;
               

                Ideo ideo = Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo;

                if (ideo.HasPrecept(InternalDefOf.VME_Scars_Honorable))
                {

                    foreach (Pawn pawn in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists)
                    {
                        PawnCollectionClass.AddColonistToScarList(pawn, 0);
                        int realNumberOfScars = 0;
                        foreach (Hediff hediff in pawn.health.hediffSet.hediffs)
                        {
                            if (hediff.IsPermanent()|| hediff.def == HediffDefOf.Scarification) {
                                realNumberOfScars++;
                            }
                        }
                        PawnCollectionClass.SetPawnScars(pawn, realNumberOfScars);
                    }

                }
                




                tickCounter = 0;
            }



        }


    }


}
