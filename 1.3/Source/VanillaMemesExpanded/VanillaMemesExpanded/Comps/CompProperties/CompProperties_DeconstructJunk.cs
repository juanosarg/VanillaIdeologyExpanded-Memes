using System;
using Verse;
using RimWorld;




namespace VanillaMemesExpanded
{
	public class CompProperties_DeconstructJunk : CompProperties
	{
		public CompProperties_DeconstructJunk()
		{
			this.compClass = typeof(CompDeconstructJunk);
		}

		public string buttonLabel = "VME_DeconstructBuildingLabel";

		public string buttonDesc = "VME_DeconstructBuildingDesc";

		public string buttonIcon = "UI/Issues/VME_AlphaIssue";

		public string buttonCancelLabel = "VME_CancelDeconstructBuildingLabel";

		public string buttonCancelDesc = "VME_CancelDeconstructBuildingDesc";

		public string buttonCancelIcon = "UI/Issues/VME_AlphaIssue";

		public ThingDef defToPopUpMinified;


	}
}

