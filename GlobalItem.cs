using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BowIsGun
{
	public class PpebIsNotFunny : GlobalItem
	{
		private static string insertFunnyMemeForDecompilerGang = "Me when uploading mod with 21 line of code :";
		public override void SetDefaults(Item item) {
			if (item.useAmmo == AmmoID.Arrow) {
				item.useAmmo = AmmoID.Bullet;
				item.UseSound = SoundID.Item11;
			}
			else if (item.useAmmo == AmmoID.Bullet) {
				item.useAmmo = AmmoID.Arrow;
				item.UseSound = SoundID.Item5;
			}
		}
	}
}