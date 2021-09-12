using System;
using RimWorld;
using Verse;
using UnityEngine;


namespace VanillaMemesExpanded
{
    public class MapComponent_FactoryModifier : MapComponent
    {

       

        public MapComponent_FactoryModifier(Map map) : base(map)
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
