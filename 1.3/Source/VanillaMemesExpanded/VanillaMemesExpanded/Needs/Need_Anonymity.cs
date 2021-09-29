using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Need_Anonymity : Need
	{
		public override float CurInstantLevel
		{
			get
			{
				if (this.lastAnonymityUseTick >= Find.TickManager.TicksGame - 10)
				{
					return Mathf.Clamp01(this.lastAnonymityUsed);
				}
				return 0f;
			}
		}
		public DessertNeedCategory CurCategory
		{
			get
			{
				if (this.CurLevel < 0.1f)
				{
					return DessertNeedCategory.Craving;
				}
				if (this.CurLevel < 0.2f)
				{
					return DessertNeedCategory.Desiring;
				}
				if (this.CurLevel < 0.3f)
				{
					return DessertNeedCategory.Wanting;
				}
				if (this.CurLevel < 0.7f)
				{
					return DessertNeedCategory.RecentlyEaten;
				}
				if (this.CurLevel < 0.9f)
				{
					return DessertNeedCategory.Full;
				}
				return DessertNeedCategory.CompletelyFull;
			}
		}

		public override bool ShowOnNeedList
		{
			get
			{

				if (!this.pawn.Ideo.HasPrecept(InternalDefOf.VME_Anonymity_Required))
				{
					return false;
				}
				else return true;


			}
		}



		public override void NeedInterval()
		{
			if (!this.IsFrozen)
			{
				this.CurLevel += this.DessertFallPerTick * 150f;
			}
		}

		private float DessertFallPerTick
		{
			get
			{
				return this.def.fallPerDay / 60000f;
			}
		}

		public Need_Anonymity(Pawn pawn) : base(pawn)
		{

		}

		public void DessertTaken(float anonymity)
		{
			this.lastAnonymityUsed = anonymity;
			this.lastAnonymityUseTick = Find.TickManager.TicksGame;
		}

		public float lastAnonymityUsed;

		public int lastAnonymityUseTick;




	}
}
