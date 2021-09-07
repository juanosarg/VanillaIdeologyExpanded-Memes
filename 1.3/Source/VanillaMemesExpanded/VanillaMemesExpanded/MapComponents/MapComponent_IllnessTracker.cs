using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_IllnessTracker : MapComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 6000;


        public MapComponent_IllnessTracker(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {

            base.FinalizeInit();

        }

      

        public override void MapComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                Ideo ideo = Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo;
                if (ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted))
                {
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
