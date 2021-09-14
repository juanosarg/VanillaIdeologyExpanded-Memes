using System;
using System.Collections.Generic;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class RitualOutcomeEffectWorker_DivineStars : RitualOutcomeEffectWorker_FromQuality
	{
		public override bool SupportsAttachableOutcomeEffect
		{
			get
			{
				return false;
			}
		}

		public RitualOutcomeEffectWorker_DivineStars()
		{
		}

		public RitualOutcomeEffectWorker_DivineStars(RitualOutcomeEffectDef def) : base(def)
		{
		}

		public override void Apply(float progress, Dictionary<Pawn, int> totalPresence, LordJob_Ritual jobRitual)
		{
			float quality = base.GetQuality(jobRitual, progress);
			OutcomeChance outcome = this.GetOutcome(quality, jobRitual);
			LookTargets lookTargets = jobRitual.selectedTarget;
			string text = null;
			if (jobRitual.Ritual != null)
			{
				this.ApplyAttachableOutcome(totalPresence, jobRitual, outcome, out text, ref lookTargets);
			}
			
			foreach (Pawn pawn in totalPresence.Keys)
			{

				base.GiveMemoryToPawn(pawn, outcome.memory, jobRitual);

			}

			foreach (Pawn pawn in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists)
			{
				Random random = new Random();
				int randomMood = random.Next(0, 9);
				PawnCollectionClass.AddColonistAndRandomMood(pawn, randomMood);
				PawnCollectionClass.SetColonistAndRandomMood(pawn, randomMood);

			}




			string text2 = outcome.description.Formatted(jobRitual.Ritual.Label).CapitalizeFirst() + "\n\n" + this.OutcomeQualityBreakdownDesc(quality, progress, jobRitual);
			string text3 = this.def.OutcomeMoodBreakdown(outcome);
			if (!text3.NullOrEmpty())
			{
				text2 = text2 + "\n\n" + text3;
			}
			
			if (text != null)
			{
				text2 = text2 + "\n\n" + text;
			}
			
			Find.LetterStack.ReceiveLetter("OutcomeLetterLabel".Translate(outcome.label.Named("OUTCOMELABEL"), jobRitual.Ritual.Label.Named("RITUALLABEL")), text2, outcome.Positive ? LetterDefOf.RitualOutcomePositive : LetterDefOf.RitualOutcomeNegative, lookTargets, null, null, null, null);
		}
	}
}
