using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer.BiomeManagers
{
	public class Crag : ModBiome
	{
		Mod _musicMod = ModLoader.HasMod("CalamityModClassicPreTrailerMusic") ? ModLoader.GetMod("CalamityModClassicPreTrailerMusic") : null;

		public override int Music => (_musicMod != null) ? MusicLoader.GetMusicSlot(_musicMod, "Sounds/Music/Crag") : MusicID.Eerie;
		
		public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
		
		public override string BestiaryIcon => "CalamityModClassicPreTrailer/BiomeManagers/BrimstoneCragsIcon";
		
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brimstone Crags");
		}
		
		public override bool IsBiomeActive(Player player) => CalamityWorldPreTrailer.calamityTiles > 50;
	}
}