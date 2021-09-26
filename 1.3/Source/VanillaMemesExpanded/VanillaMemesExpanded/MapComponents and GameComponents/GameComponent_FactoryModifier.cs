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
            if (Current.Game.World.factionManager.OfPlayer.ideos.GetPrecept(InternalDefOf.VME_AutomationEfficiency_Increased) != null)
            {
                ItemProcessor.FactoryMultiplierClass.FactoryPreceptMultiplier = 0.75f;
            }
            if (Current.Game.World.factionManager.OfPlayer.ideos.GetPrecept(InternalDefOf.VME_AutomationEfficiency_Decreased) != null)
            {
                ItemProcessor.FactoryMultiplierClass.FactoryPreceptMultiplier = 1.5f;
            }
            base.FinalizeInit();

        }

      



    }


}
