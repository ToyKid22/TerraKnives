using TerraKnives.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Items.Weapons
{
	public class DemoniteThrowingKnife : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Demonite Throwing Knife");
		}
		
		public override void SetDefaults() {
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 12.5f;
			item.damage = 20;
			item.knockBack = 0f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 22;
			item.useTime = 22;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = ItemRarityID.Blue;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 53);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<DemoniteKnifeProjectile>();
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}