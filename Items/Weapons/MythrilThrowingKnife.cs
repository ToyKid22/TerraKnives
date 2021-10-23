using TerraKnives.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraKnives.Items.Weapons
{
	public class MythrilThrowingKnife : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mythril Throwing Knife");
		}
		
		public override void SetDefaults() {
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 10f;
			item.damage = 47;
			item.knockBack = 0f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 24;
			item.useTime = 24;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.crit = 8;
			item.rare = ItemRarityID.LightRed;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 73);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<MythrilKnifeProjectile>();
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.MythrilBar, 1);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}