using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CalamityModClassicPreTrailer.BiomeManagers.Scenes
{
	public class UniversalCollapse : ModSceneEffect
	{
		Mod _musicMod = ModLoader.HasMod("CalamityModClassicPreTrailerMusic") ? ModLoader.GetMod("CalamityModClassicPreTrailerMusic") : null;
 	    public override int Music => (_musicMod != null) ? MusicLoader.GetMusicSlot(_musicMod, "Sounds/Music/UniversalCollapse") : MusicID.LunarBoss;
		public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

		public virtual bool SetSceneEffect(Player player) => CalamityWorldPreTrailer.DoGSecondStageCountdown <= 540 &&
		                                                     CalamityWorldPreTrailer.DoGSecondStageCountdown > 6;
		public override bool IsSceneEffectActive(Player player) => SetSceneEffect(player);
	}
}