﻿using System;
using AlienInvasion.Fleets;

namespace AlienInvasion
{
    namespace Ships
    {
        class DestroyerShip : AlienShipBase
        {
            public DestroyerShip(int shipIndex, int internalFleetIndex, int health, string pilotName, ShipType type, AlienFleet fleet)
                : base(shipIndex, internalFleetIndex, health, pilotName, type, fleet)
            {

            }
        }
    }
}
