using System.Linq;
using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("GivePistol", "sdapro", "0.0.0")]
    public class GivePistol : CovalencePlugin
    {
        [ChatCommand("givepistol")]
        private void GivePistolCommand(IPlayer player, string command, string[] args)
        {
            if (!player.IsAdmin)
            {
                player.Reply("Сосать хуй! ты не админ");
                return;
            }

            BasePlayer basePlayer = player.Object as BasePlayer;
            if (basePlayer == null) return;
            var pistol = ItemManager.CreateByName("pistol.semiauto", 1);
            if (pistol == null) { return; }
            var laserSight = ItemManager.CreateByName("weapon.mod.lasersight", 1);
            if (laserSight == null) { return; }
            pistol.contents.AddItem(laserSight.info, laserSight.amount);
            basePlayer.inventory.GiveItem(pistol);
            player.Reply("Вы получили благословение на использование мистера Пениса.");
        }
    }
}