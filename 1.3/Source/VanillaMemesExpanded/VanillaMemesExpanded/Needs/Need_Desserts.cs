using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Need_Desserts : Need
	{
		public override float CurInstantLevel
		{
			get
			{
				if (this.lastDessertUseTick >= Find.TickManager.TicksGame - 10)
				{
					return Mathf.Clamp01(this.lastDessertUsed);
				}
				return 0f;
			}
		}

		public override bool ShowOnNeedList
		{
			get
			{
				
				if(DefDatabase<MemeDef>.GetNamedSilentFail("VME_SweetTeeth")==null || !Current.Game.World.factionManager.OfPlayer.ideos.HasAnyIdeoWithMeme(DefDatabase<MemeDef>.GetNamedSilentFail("VME_SweetTeeth")))
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
				this.CurLevel -= this.DessertFallPerTick * 150f;
			}
		}

		private float DessertFallPerTick
		{
			get
			{
				return this.def.fallPerDay / 60000f;
			}
		}

		public Need_Desserts(Pawn pawn) : base(pawn)
		{
			
		}

		public void DessertTaken(float dessert)
		{
			this.lastDessertUsed = dessert;
			this.lastDessertUseTick = Find.TickManager.TicksGame;
		}

		public float lastDessertUsed;

		public int lastDessertUseTick;

		

		
	}
}
