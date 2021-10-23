using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Projectiles
{
	public class TitaniumKnifeProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium Throwing Knife");
		}

		public override void SetDefaults()
		{
			projectile.width = 5;
			projectile.height = 12;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 5;
			aiType = ProjectileID.ThrowingKnife;
		}

		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int d = 0; d < 12; d++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 84, 0f, 0f, 0, Color.White, 0.75f);
			}
		}
	}
}