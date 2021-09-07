
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


        public static IDictionary<Pawn, int> colonist_illness_tracker = new Dictionary<Pawn, int>();

        public static int ticksWithoutTrading = 0;


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



    }
}
