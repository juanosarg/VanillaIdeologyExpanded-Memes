
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

        public static Pawn pawnThatIsTheLeaderNow;


        public static int ticksWithoutTrading = 0;

        public static int ticksWithoutAbandoning = 0;


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





    }
}
