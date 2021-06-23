using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using UnityEngine;
using RimWorld.Planet;

namespace VanillaMemesExpanded
{
    public class MapComponent_IdeologicalGoodies : MapComponent
    {



        public MapComponent_IdeologicalGoodies(Map map) : base(map)
        {

        }



        public override void MapComponentTick()
        {
            base.MapComponentTick();
            if (!Current.Game.GetComponent<GameComponent_IdeologicalGoodies>().sentOncePerGame)
            {

                List<Thing> things = new List<Thing>();
                PawnGenerationRequest request = new PawnGenerationRequest(PawnKindDef.Named("Alpaca"), null, PawnGenerationContext.NonPlayer, -1, false, false, false, false, true, false, 1f, false, true, true, true, false, false, false, false, 0f, 0f,null, 1f, null, null, null, null, null, null, null, null, null, null, null, null);
                Pawn pawn = PawnGenerator.GeneratePawn(request);
                things.Add(pawn);

                DropPodUtility.DropThingsNear(MapGenerator.PlayerStartSpot, map, things, 110);
               
                Current.Game.GetComponent<GameComponent_IdeologicalGoodies>().sentOncePerGame = true;
            }


        }


    }


}

