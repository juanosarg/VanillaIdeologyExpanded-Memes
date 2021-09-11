using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
    public class Thought_Junk_Beautiful : ThoughtWorker_Precept
    {
        protected override ThoughtState ShouldHaveThought(Pawn p)
        {

            if (!PawnCollectionClass.colonist_junk_tracker.ContainsKey(p))
            {
                return false;
            }
            else if (PawnCollectionClass.colonist_junk_tracker[p] == 0)
            {
                return ThoughtState.ActiveAtStage(0);

            }
            else
            {
                if (PawnCollectionClass.colonist_junk_tracker[p] < 2)
                { return ThoughtState.ActiveAtStage(1); }
                else
                if (PawnCollectionClass.colonist_junk_tracker[p] < 5)
                { return ThoughtState.ActiveAtStage(2); }
                else
                if (PawnCollectionClass.colonist_junk_tracker[p] < 7)
                { return ThoughtState.ActiveAtStage(3); }
                else
                if (PawnCollectionClass.colonist_junk_tracker[p] < 10)
                { return ThoughtState.ActiveAtStage(4); }
                else
                return ThoughtState.ActiveAtStage(5);






            }



        }


    }
}
