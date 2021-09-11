using System;
using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
    public class MapComponent_RoomsInMap : MapComponent
    {



        public int tickCounter = 0;
        public int tickInterval = 6000;
        public int roomsInMap_backup;


        public MapComponent_RoomsInMap(Map map) : base(map)
        {

        }

        public override void FinalizeInit()
        {
            PawnCollectionClass.roomsInMap = roomsInMap_backup;

            base.FinalizeInit();

        }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref this.roomsInMap_backup, "roomsInMap_backup", 0, true);
            Scribe_Values.Look<int>(ref this.tickCounter, "tickCounterRooms", 0, true);

        }
        public override void MapComponentTick()
        {


            tickCounter++;
            if ((tickCounter > tickInterval))
            {
                roomsInMap_backup=PawnCollectionClass.roomsInMap;

                int totalRooms = 0;

                foreach (Room room in map.regionGrid.allRooms)
                {
                    if (room.CellCount>25)
                    {
                        totalRooms++;
                    }
                }
                roomsInMap_backup = totalRooms;
               

                tickCounter = 0;
            }



        }
       



    }


}



