using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_TradingTracker : MapComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 6000; 

       


        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounter", 0, true);


        }

        public MapComponent_TradingTracker(Map map) : base(map)
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
                if (ideo.HasPrecept(InternalDefOf.VME_Trading_Required))
                {
                    if (PawnCollectionClass.ticksWithoutTrading < int.MaxValue - tickInterval)
                    {
                        PawnCollectionClass.ticksWithoutTrading += tickInterval;
                    }
                        

                }

                tickCounter = 0;
            }



        }


    }


}
