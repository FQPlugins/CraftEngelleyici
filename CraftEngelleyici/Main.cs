using Rocket.API;
using Rocket.Core.Commands;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CraftEngelleyici
{
    public class Main : RocketPlugin<Config>
    {
        protected override void Load()
        {
            PlayerCrafting.onCraftBlueprintRequested += new PlayerCraftingRequestHandler(craftEngelle);
        }

        private void craftEngelle(PlayerCrafting c, ref ushort itemID, ref byte blueprintIndex, ref bool shouldAllow)
        {
            var player = UnturnedPlayer.FromPlayer(c.player);
            foreach(var i in Configuration.Instance.craftableItems)
            {
                if(i.item.Contains(itemID)){
                    if (player.HasPermission(i.Permission))
                    {
                        shouldAllow = true;
                        return;
                    }
                }
            }
            shouldAllow = false;
            UnturnedChat.Say(player,"Üzgünüm, bu itemi craftlayamazsın.", Color.red);
            return;

        }
    }
}
