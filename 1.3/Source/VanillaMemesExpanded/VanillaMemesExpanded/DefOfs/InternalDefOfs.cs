﻿using System;
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

		public static PreceptDef VME_Leader_Godlike;

		public static PreceptDef VME_Leader_BestCrafter;

		public static PreceptDef VME_Power_Exalted;

		public static PreceptDef VME_Power_Desired;

		public static PreceptDef VME_Power_Preferred;

		public static PreceptDef VME_DumbLabor_Horrible;

		public static PreceptDef VME_WoodcuttingYield_High;

		public static PreceptDef VME_FarmingYield_High;

		public static PreceptDef VME_Illness_Exalted;

		public static PreceptDef VME_CraftingQuality_Increased;

		public static PreceptDef VME_AutomationEfficiency_Increased;

		public static PreceptDef VME_CraftingSpeed_SlowerForManual;

		public static PreceptDef VME_IdeoRole_LeaderSecond;

		public static PreceptDef VME_IdeoRole_LeaderThird;

		public static PreceptDef VME_Trading_Required;

		public static PreceptDef VME_Elders_Holy;

		public static HistoryEventDef VME_MoodOfTheStars;

		public static HistoryEventDef VME_DumbLabor;

		public static HistoryEventDef VME_InstalledNonNaturalProsthetic;

		public static HistoryEventDef VME_Defeat;

		public static TraitDef VME_Elder;


	}
}
