using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class GameComponent_TradingTracker : GameComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 6000;
        public int ticksWithoutTradingbackup;





        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterTrade", 0, true);
            Scribe_Values.Look<int>(ref this.ticksWithoutTradingbackup, "ticksWithoutTradingbackup", 0, true);


        }

        public GameComponent_TradingTracker(Game game) : base()
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.ticksWithoutTrading = ticksWithoutTradingbackup;
            base.FinalizeInit();

        }

      

        public override void GameComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                ticksWithoutTradingbackup=PawnCollectionClass.ticksWithoutTrading;

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
