using System;
using RimWorld;
using Verse;
using UnityEngine;


namespace VanillaMemesExpanded
{
    public class MapComponent_MoodFromStars : MapComponent
    {

        //This class updates all the rooms in the map every 2000 ticks if a pedigreed raptor is in the map

       
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

      

        public override void MapComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {
               
                Find.HistoryEventsManager.RecordEvent(new HistoryEvent(DefDatabase<HistoryEventDef>.GetNamed("VME_MoodOfTheStars")), true);

                tickCounter = 0;
            }



        }


    }


}
