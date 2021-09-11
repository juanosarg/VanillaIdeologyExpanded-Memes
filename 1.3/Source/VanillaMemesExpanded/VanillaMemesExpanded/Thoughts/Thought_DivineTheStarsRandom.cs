using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Thought_DivineTheStarsRandom : Thought_Memory
	{
		public override string LabelCap
		{
			get
			{
				return base.CurStage.LabelCap.Formatted(this.sourcePrecept.Named("RITUAL"));
			}
		}

		public override string Description
		{
			get
			{
				return base.CurStage.description.Formatted(this.sourcePrecept.Named("RITUAL"));
			}
		}

        public bool added = false;


        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<bool>(ref this.added, "added", false, false);
        }


        public override float MoodOffset()
        {
            if (!added)
            {

                System.Random random = new System.Random();



                if (random.NextDouble() < 0.2)
                {
                    this.SetForcedStage(0);

                }
                else if(random.NextDouble() < 0.4)
                {
                    this.SetForcedStage(1);

                }
                else if(random.NextDouble() < 0.6)
                {
                    this.SetForcedStage(2);

                }
                else if(random.NextDouble() < 0.8)
                {
                    this.SetForcedStage(3);

                }
                else
                {
                    this.SetForcedStage(4);
                }



                added = true;
            }


            return base.MoodOffset();
        }
    }
}
