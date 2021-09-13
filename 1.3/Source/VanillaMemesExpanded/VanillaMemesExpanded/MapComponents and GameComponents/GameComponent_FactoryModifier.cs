using System;
using RimWorld;
using Verse;
using UnityEngine;


namespace VanillaMemesExpanded
{
    public class GameComponent_FactoryModifier : GameComponent
    {

       

        public GameComponent_FactoryModifier(Game game) : base()
        {

        }

        public override void FinalizeInit()
        {
            if (Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo.HasPrecept(InternalDefOf.VME_AutomationEfficiency_Increased))
            {
                ItemProcessor.FactoryMultiplierClass.FactoryPreceptMultiplier = 0.75f;
            }
            if (Current.Game.World.factionManager.OfPlayer.ideos.PrimaryIdeo.HasPrecept(InternalDefOf.VME_AutomationEfficiency_Decreased))
            {
                ItemProcessor.FactoryMultiplierClass.FactoryPreceptMultiplier = 1.5f;
            }
            base.FinalizeInit();

        }

      



    }


}
