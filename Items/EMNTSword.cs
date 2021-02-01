using Terraria.ID;
using Terraria.ModLoader;

namespace ExamplentMod.Items //namespace
{
	public class EMNTSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EMNTSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("this is your tooltip.\nheres line two.");
		}

		public override void SetDefaults() 
		{
			item.damage = 50; //damage
			item.melee = true; //melee weapon, if you want to change it, replace melee with range, magic, summon.
	      		//item.mana = 69; consumes 69 mana per use
			item.width = 40; //hitbox width
			item.height = 40; //hitbox height
			item.useTime = 20; 
			item.useAnimation = 20;
			item.useStyle = 1; // 1 - Swing, 2 - Eat, 3 - Stab (Shortswords), 4 - Holding Up (Life Crystal and Boss Summmons), 5 - Holding Out (Mage Weapons)
			item.knockBack = 6; //knockback value
			item.value = 10000; //sell price, 1 = 1 copper so 10000 = 1 gold coin
			item.rare = 2; //colors
			item.UseSound = SoundID.Item1; 
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
      recipe.AddIngredient(ItemID.WandOfSparking, 1); //max number of recipes is 14
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
