using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer.Items.Placeables
{
    public class CalamityMusicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Music Box (Calamity)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = Mod.Find<ModTile>("CalamityMusicbox").Type;
            Item.width = 24;
            Item.height = 24;
            Item.rare = 4;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModLoader.TryGetMod("CalamityModClassicPreTrailer", out Mod calamityModClassicPreTrailer);
            if (calamityModClassicPreTrailer != null)
            {
                Recipe recipe = CreateRecipe(1);
                recipe.AddIngredient(calamityModClassicPreTrailer.Find<ModItem>("BrimstoneSlag").Type, 12);
                recipe.AddIngredient(calamityModClassicPreTrailer.Find<ModItem>("EssenceofChaos").Type, 3);
                recipe.AddTile(calamityModClassicPreTrailer.Find<ModTile>("AshenAltar").Type);
                recipe.Register();
            } 
        }
    }
}