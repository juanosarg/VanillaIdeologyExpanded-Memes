using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;


namespace VanillaMemesExpanded
{
    public class GameComponent_AverageMoodTracker : GameComponent
    {



        public int tickCounter = 0;
        public int tickInterval = 6000;
        public float averageColonyMood_backup;


        public GameComponent_AverageMoodTracker(Game game) : base()
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
        public override void GameComponentTick()
        {


            tickCounter++;
            if ((tickCounter > tickInterval))
            {

              
                
                if (Current.Game.World.factionManager.OfPlayer.ideos.HasAnyIdeoWithMeme(InternalDefOf.VME_Astrology))
                {
                   
                    float totalMood = 0;
                    foreach (Pawn pawn in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists)
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



