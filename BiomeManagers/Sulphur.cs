using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer.BiomeManagers
{
	public class Sulphur : ModBiome
	{
		Mod _musicMod = ModLoader.HasMod("CalamityModClassicPreTrailerMusic") ? ModLoader.GetMod("CalamityModClassicPreTrailerMusic") : null;

		public override int Music => (_musicMod != null) ? MusicLoader.GetMusicSlot(_musicMod, "Sounds/Music/Sulphur") : MusicID.Desert;

		public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
		
		public override ModWaterStyle WaterStyle => ModContent.Find<ModWaterStyle>("CalamityModClassicPreTrailer/SulphuricWater");
		
		public override string BestiaryIcon => "CalamityModClassicPreTrailer/BiomeManagers/SulpherousSeaIcon";

		public override string MapBackground => "CalamityModClassicPreTrailer/Backgrounds/MapBackgrounds/SulphurBG";
		
		public override string BackgroundPath => "CalamityModClassicPreTrailer/Backgrounds/MapBackgrounds/SulphurBG";
		
		public override ModSurfaceBackgroundStyle SurfaceBackgroundStyle => ModContent.Find<ModSurfaceBackgroundStyle>("CalamityModClassicPreTrailer/SulphurSeaSurfaceBGStyle");

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sulphurous Sea");
		}
		
		public override bool IsBiomeActive(Player player)
		{
			Point point = player.Center.ToTileCoordinates();
			bool sulphurPosX = false;
			if (CalamityWorldPreTrailer.abyssSide)
			{
				if (point.X < 380)
				{
					sulphurPosX = true;
				}
			}
			else
			{
				if (point.X > Main.maxTilesX - 380)
				{
					sulphurPosX = true;
				}
			}
			return (CalamityWorldPreTrailer.sulphurTiles > 30 || (player.ZoneOverworldHeight && sulphurPosX)) && !player.GetModPlayer<CalamityPlayerPreTrailer>().ZoneAbyss;
		}
	}
}