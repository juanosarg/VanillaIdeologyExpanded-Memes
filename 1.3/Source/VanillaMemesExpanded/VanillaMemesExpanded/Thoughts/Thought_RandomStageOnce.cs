


using Verse;
using System.Collections.Generic;
using System.Linq;
using RimWorld;

namespace VanillaMemesExpanded
{

  
    class Thought_RandomStageOnce : Thought_Memory
    {
       
        public bool added = false;

       
        public override void ExposeData()
        {
            Scribe_Values.Look<bool>(ref this.added, "added", false, false);
        }

       
        public override float MoodOffset()
        {
            if (!added)
            {

                System.Random random = new System.Random();

               

                if (random.NextDouble() > 0.5)
                {
                    this.SetForcedStage(0);
                  
                }
                else
                {
                    this.SetForcedStage(1);
                }



                added = true;
            }


            return base.MoodOffset();
        }


    }
}
