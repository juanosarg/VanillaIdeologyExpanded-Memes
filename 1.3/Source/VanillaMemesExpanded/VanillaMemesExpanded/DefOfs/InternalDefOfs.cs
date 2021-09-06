using System;
using RimWorld;

namespace VanillaMemesExpanded
{
	[DefOf]
	public static class InternalDefOf
	{
		static InternalDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
		}

		[MayRequireIdeology]
		public static PreceptDef VME_Leader_Godlike;

		[MayRequireIdeology]
		public static PreceptDef VME_Leader_BestCrafter;

		[MayRequireIdeology]
		public static PreceptDef VME_Power_Exalted;

		[MayRequireIdeology]
		public static PreceptDef VME_WoodcuttingYield_High;

		[MayRequireIdeology]
		public static PreceptDef VME_FarmingYield_High;

		[MayRequireIdeology]
		public static PreceptDef VME_Illness_Exalted;

	
		[MayRequireIdeology]
		public static HistoryEventDef VME_MoodOfTheStars;

		[MayRequireIdeology]
		public static HistoryEventDef VME_DumbLabor;

		[MayRequireIdeology]
		public static HistoryEventDef VME_InstalledNonNaturalProsthetic;

	}
}
