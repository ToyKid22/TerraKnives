using TerraKnives.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Items.Weapons
{
	public class CobaltThrowingKnife : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cobalt Throwing Knife");
		}
		
		public override void SetDefaults() {
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 13f;
			item.damage = 37;
			item.knockBack = 0f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = ItemRarityID.LightRed;
			item.crit = 9;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 40);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<CobaltKnifeProjectile>();
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}