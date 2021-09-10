using System;
using RimWorld;
using Verse;
using UnityEngine;


namespace VanillaMemesExpanded
{
    public class MapComponent_MoodFromStars : MapComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 900000; //15 days

        //public int tickInterval = 2500; //For testing


        public MapComponent_MoodFromStars(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {

            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

          
            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterStars", 0, true);

        }

        public override void MapComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
               
                Find.HistoryEventsManager.RecordEvent(new HistoryEvent(InternalDefOf.VME_MoodOfTheStars), true);

                tickCounter = 0;
            }



        }


    }


}
