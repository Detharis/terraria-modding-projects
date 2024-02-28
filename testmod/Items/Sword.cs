using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace testmod.Items
{
	public class Sword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.testmod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 4.5f;
			Item.value = 1000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.EnchantedBeam;
			Item.shootSpeed = 7.5f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.Wood, 2);

            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}