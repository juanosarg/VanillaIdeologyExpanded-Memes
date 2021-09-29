using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class ThoughtWorker_Anonymity : ThoughtWorker
	{
		protected override ThoughtState CurrentStateInternal(Pawn p)
		{
			if (p.needs?.TryGetNeed<Need_Anonymity>() == null)
			{
				return ThoughtState.Inactive;
			}

			if (p.Ideo?.HasPrecept(InternalDefOf.VME_Anonymity_Required)==false)
			{
				return ThoughtState.Inactive;
			}
			Need_Anonymity need = p.needs.TryGetNeed<Need_Anonymity>();
			switch (need.CurCategory)
			{
				case DessertNeedCategory.Craving:
					return ThoughtState.ActiveAtStage(0);
				case DessertNeedCategory.Desiring:
					return ThoughtState.ActiveAtStage(1);
				case DessertNeedCategory.Wanting:
					return ThoughtState.ActiveAtStage(2);
				case DessertNeedCategory.RecentlyEaten:
					return ThoughtState.Inactive;
					
				case DessertNeedCategory.Full:
					return ThoughtState.ActiveAtStage(3);
				case DessertNeedCategory.CompletelyFull:
					return ThoughtState.ActiveAtStage(4);
				default:
					throw new NotImplementedException();
			}
		}
	}
}
