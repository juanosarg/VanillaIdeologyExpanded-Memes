﻿
using Verse;
using System;
using RimWorld;
using System.Collections.Generic;
using System.Linq;


namespace VanillaMemesExpanded
{

    public static class PawnCollectionClass
    {

        //This static class stores lists of animals and pawns for different things.


        public static Dictionary<Pawn, int> colonist_illness_tracker = new Dictionary<Pawn, int>();

        public static Dictionary<Pawn, int> colonist_caravan_tracker = new Dictionary<Pawn, int>();

        public static Dictionary<Pawn, int> colonist_scar_counter = new Dictionary<Pawn, int>();

        public static Dictionary<Pawn, int> colonist_junk_tracker = new Dictionary<Pawn, int>();

        public static Dictionary<Pawn, int> colonist_booze_tracker = new Dictionary<Pawn, int>();

        public static Dictionary<Pawn, int> colonist_and_random_mood = new Dictionary<Pawn, int>();




        public static Pawn pawnThatIsTheLeaderNow;

        public static float averageColonyMood = 0;


        public static int ticksWithoutTrading = 0;

        public static int roomsInMap = 0;

        public static int ticksWithoutAbandoning = 0;

        public static int firesInTheMap = 0;



        public static void AddColonistToIllnessList(Pawn pawn, int ticks)
        {
            if (!colonist_illness_tracker.ContainsKey(pawn))
            {
                colonist_illness_tracker.Add(pawn, ticks);
            }
        }

        public static void IncreasePawnIllnessTicks(Pawn pawn, int ticks)
        {
           
            colonist_illness_tracker[pawn] += ticks;
            
        }
        public static void ResetPawnIlnessTicks(Pawn pawn)
        {

            colonist_illness_tracker[pawn] = 0;

        }

        public static void AddColonistToCaravanList(Pawn pawn, int ticks)
        {
            if (!colonist_caravan_tracker.ContainsKey(pawn))
            {
                colonist_caravan_tracker.Add(pawn, ticks);
            }
        }

        public static void IncreasePawnCaravanTicks(Pawn pawn, int ticks)
        {

            colonist_caravan_tracker[pawn] += ticks;

        }
        public static void ResetPawnCaravanTicks(Pawn pawn)
        {

            colonist_caravan_tracker[pawn] = 0;

        }

        public static void AddColonistToScarList(Pawn pawn, int scars)
        {
            if (!colonist_scar_counter.ContainsKey(pawn))
            {
                colonist_scar_counter.Add(pawn, scars);
            }
        }

        public static void SetPawnScars(Pawn pawn, int scars)
        {

            colonist_scar_counter[pawn] = scars;

        }

        public static void AddColonistToJunkList(Pawn pawn, int numOfJunk)
        {
            if (!colonist_junk_tracker.ContainsKey(pawn))
            {
                colonist_junk_tracker.Add(pawn, numOfJunk);
            }
        }

        public static void SetPawnJunk(Pawn pawn, int numOfJunk)
        {

            colonist_junk_tracker[pawn] = numOfJunk;

        }

        public static void AddColonistToBoozeList(Pawn pawn, int ticks)
        {
            if (!colonist_booze_tracker.ContainsKey(pawn))
            {
                colonist_booze_tracker.Add(pawn, ticks);
            }
        }

        public static void IncreasePawnBoozeTicks(Pawn pawn, int ticks)
        {

            colonist_booze_tracker[pawn] += ticks;

        }
        public static void ResetPawnBoozeTicks(Pawn pawn)
        {

            colonist_booze_tracker[pawn] = 0;

        }

        public static void AddColonistAndRandomMood(Pawn pawn, int mood)
        {
            if (!colonist_and_random_mood.ContainsKey(pawn))
            {
                colonist_and_random_mood.Add(pawn, mood);
            }
        }

        public static void SetColonistAndRandomMood(Pawn pawn, int mood)
        {

            colonist_and_random_mood[pawn] = mood;

        }


    }
}