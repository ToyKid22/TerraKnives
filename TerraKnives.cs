using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TerraKnives
{
	public class TerraKnives : Mod
	{
		public TerraKnives()
		{
		}
		
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper Bar", new int[]
			{
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("TerraKnives:CopperBar", group);

			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Bar", new int[]
			{
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("TerraKnives:GoldBar", group2);
			
			RecipeGroup group3 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Bar", new int[]
			{
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("TerraKnives:SilverBar", group3);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("IronBar", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ThrowingKnife, 50);
			recipe.AddRecipe();
		}

	}
}