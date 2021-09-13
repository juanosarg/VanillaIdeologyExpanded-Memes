using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class GameComponent_IllnessTracker : GameComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 6000;
        public Dictionary<Pawn, int> colonist_illness_tracker_backup = new Dictionary<Pawn, int>();
        List<Pawn> list2;
        List<int> list3;



        public GameComponent_IllnessTracker(Game game) : base()
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.colonist_illness_tracker = colonist_illness_tracker_backup;            
            base.FinalizeInit();

        }

        public override void ExposeData()
       {
           base.ExposeData();

           Scribe_Collections.Look(ref colonist_illness_tracker_backup, "colonist_illness_tracker_backup", LookMode.Reference, LookMode.Value, ref list2, ref list3);           
          
       }



        public override void GameComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                Ideo ideo = Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo;
                if (ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted))
                {
                    colonist_illness_tracker_backup = PawnCollectionClass.colonist_illness_tracker;
                    List<Pawn> listPawns = PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists;
                    foreach(Pawn p in listPawns)
                    {
                        if (p.Ideo == ideo)
                        {
                            PawnCollectionClass.AddColonistToIllnessList(p,0);

                            if (p.health.hediffSet.AnyHediffMakesSickThought)
                            {
                                PawnCollectionClass.ResetPawnIlnessTicks(p);
                            }
                            else { 
                                if(PawnCollectionClass.colonist_illness_tracker[p]<int.MaxValue- tickInterval)
                                {
                                    PawnCollectionClass.IncreasePawnIllnessTicks(p, tickInterval);

                                }
                            }


                        }

                    }

                }

                tickCounter = 0;
            }



        }


    }


}
