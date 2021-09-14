using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class GameComponent_MoodFromStars : GameComponent
    {

       
       
        public int tickCounter = 0;
        public int tickInterval = 2000;
        public Dictionary<Pawn, int> colonist_and_random_mood_backup = new Dictionary<Pawn, int>();
        List<Pawn> list2;
        List<int> list3;


        public GameComponent_MoodFromStars(Game game) : base()
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.colonist_and_random_mood = colonist_and_random_mood_backup;

            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Collections.Look(ref colonist_and_random_mood_backup, "colonist_and_random_mood_backup", LookMode.Reference, LookMode.Value, ref list2, ref list3);

            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterStars", 0, true);

        }

        public override void GameComponentTick()
        {

          
            tickCounter++;
            if ((tickCounter > tickInterval))
            {

                colonist_and_random_mood_backup= PawnCollectionClass.colonist_and_random_mood;


                tickCounter = 0;
            }



        }


    }


}
