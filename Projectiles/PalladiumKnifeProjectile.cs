using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Projectiles
{
	public class PalladiumKnifeProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palladium Throwing Knife");
		}
	
		public override void SetDefaults()
		{
			projectile.width = 5;
			projectile.height = 12;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			aiType = ProjectileID.ThrowingKnife;
		}
			
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			if (projectile.owner == Main.myPlayer) {
				Main.LocalPlayer.AddBuff(BuffID.RapidHealing, 60);
			}
		}
			
		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int d = 0; d < 12; d++) {
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 144, 0f, 0f, 0, Color.White, 0.75f);
			}
		}
	}
}