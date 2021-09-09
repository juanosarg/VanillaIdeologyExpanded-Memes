using System;
using Verse;
using RimWorld;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
	public class RitualObligationTrigger_StrongerLeader : RitualObligationTrigger
	{

		public int tickCounter = 0;
		public int tickInterval = 6000;
		private static List<Pawn> existingObligations = new List<Pawn>();

		public override void Tick()
		{
			tickCounter++;
			if ((tickCounter > tickInterval))
			{

				GameComponent_BestMeleeLeaderTracker comp = Current.Game.GetComponent<GameComponent_BestMeleeLeaderTracker>();
				if (this.ritual.activeObligations != null)
				{
					foreach (RitualObligation ritualObligation in this.ritual.activeObligations)
					{
						existingObligations.Add(ritualObligation.targetA.Thing as Pawn);
					}

				}

				
					if (!existingObligations.Contains(comp.mostSkilledPawn) && comp.mostSkilledPawn.Ideo != null)
					{
						
						if (comp.mostSkilledPawn != comp.pawnThatIsTheLeaderNow)
						{
							this.ritual.AddObligation(new RitualObligation(this.ritual, comp.mostSkilledPawn, false));
						}
					}
				
				tickCounter = 0;
				existingObligations.Clear();
			}


		}

	}
}