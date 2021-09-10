using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_AverageMoodTracker : MapComponent
    {



        public int tickCounter = 0;
        public int tickInterval = 6000;
        public float averageColonyMood_backup;


        public MapComponent_AverageMoodTracker(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.averageColonyMood = averageColonyMood_backup;

            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<float>(ref this.averageColonyMood_backup, "averageColonyMood_backup");
            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterMood", 0, true);

        }
        public override void MapComponentTick()
        {


            tickCounter++;
            if ((tickCounter > tickInterval))
            {

              
                Ideo ideo = Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo;
                if (ideo.HasPrecept(InternalDefOf.VME_Mood_Shared))
                {
                   
                    float totalMood = 0;
                    foreach (Pawn pawn in map.mapPawns.FreeColonistsSpawned)
                    {
                        totalMood += pawn.needs.mood.thoughts.TotalMoodOffset();
                    }
                   
                    averageColonyMood_backup = totalMood;
                    PawnCollectionClass.averageColonyMood = totalMood;
                }

                tickCounter = 0;
            }



        }
       



    }


}



