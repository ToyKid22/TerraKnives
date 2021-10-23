using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Projectiles
{
	public class MeteorKnifeProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteor Throwing Knife");
		}

		public override void SetDefaults()
		{
			projectile.width = 5;
			projectile.height = 12;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 2;
			aiType = ProjectileID.ThrowingKnife;
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity) {
			//If collide with tile, reduce the penetrate.
			//So the projectile can reflect at most 5 times
			projectile.penetrate--;
			if (projectile.penetrate <= 0) {
				projectile.Kill();
			}
			else {
				Main.PlaySound(SoundID.Item10, projectile.position);
				if (projectile.velocity.X != oldVelocity.X) {
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y) {
					projectile.velocity.Y = -oldVelocity.Y;
				}
			}
			return false;
		}
		
		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int d = 0; d < 12; d++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 22, 0f, 0f, 0, Color.White, 0.75f);
			}
		}
	}
}