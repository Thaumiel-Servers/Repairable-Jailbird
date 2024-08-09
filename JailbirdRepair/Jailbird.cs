using System.Collections.Generic;
using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Roles;
using InventorySystem.Items.Jailbird;
using Exiled.API.Features.Items;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using EPlayer = Exiled.API.Features.Player;
using MEC;
using PlayerRoles;
using UnityEngine;
using static PlayerList;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
using Exiled.API.Features.Spawn;

namespace JailbirdRepair
{
    public class Jailbird
    {



        [CustomItem(ItemType.Jailbird)]
        public class JailbirdRepairing : CustomItem
        {
            public JailbirdRepairing(int wearState)
            {
                WearState = wearState;
            }

            public override uint Id { get; set; } = 30;

            public override string Name { get; set; } = "Repairable Jailbird";

            public override ItemType Type { get; set; } = ItemType.Jailbird;

            public override string Description { get; set; } =
                "A Jailbird that can be repaired at weapon modification stations.";

            public override Exiled.API.Features.Spawn.SpawnProperties SpawnProperties { get; set; }


            public override float Weight { get; set; } = 1.7f;

            public int WearState { get; set; }
            {
                If WearState = <= 4
                
            } 

        }
    }
}