using System;
using Terraria;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer
{
	internal class WeakReferenceSupport
	{
		public static void Setup()
		{
			BossChecklistSupport();
			CensusSupport();
		}

		private static void BossChecklistSupport()
		{
			Mod mod = ModLoader.GetMod("CalamityModClassicPreTrailer");
			if (ModLoader.HasMod("BossChecklist"))
			{
				Mod bossChecklist = ModLoader.GetMod("BossChecklist");
				// 14 is moonlord, 12 is duke fishron
				bossChecklist.Call("AddBossWithInfo", "Desert Scourge", 1.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedDesertScourge), "Use a [i:" + mod.Find<ModItem>("DriedSeafood").Type + "] in the Desert Biome"); //1
				bossChecklist.Call("AddBossWithInfo", "Crabulon", 2.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedCrabulon), "Use a [i:" + mod.Find<ModItem>("DecapoditaSprout").Type + "] in the Mushroom Biome"); //1.5
				bossChecklist.Call("AddBossWithInfo", "Hive Mind / Perforator", 3.5f, (Func<bool>)(() => (CalamityWorldPreTrailer.downedPerforator || CalamityWorldPreTrailer.downedHiveMind)), "By killing a Cyst in the World's Evil Biome"); //2
				bossChecklist.Call("AddBossWithInfo", "Slime God", 5.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedSlimeGod), "Use an [i:" + mod.Find<ModItem>("OverloadedSludge").Type + "]"); //4
				bossChecklist.Call("AddBossWithInfo", "Cryogen", 6.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedCryogen), "Use a [i:" + mod.Find<ModItem>("CryoKey").Type + "] in the Snow Biome"); //5
				bossChecklist.Call("AddBossWithInfo", "Brimstone Elemental", 7.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedBrimstoneElemental), "Use a [i:" + mod.Find<ModItem>("CharredIdol").Type + "] in the Hell Crag"); //6
				bossChecklist.Call("AddBossWithInfo", "Aquatic Scourge", 8.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedAquaticScourge), "Use a [i:" + mod.Find<ModItem>("Seafood").Type + "] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea"); //6
				bossChecklist.Call("AddBossWithInfo", "Calamitas", 9.7f, (Func<bool>)(() => CalamityWorldPreTrailer.downedCalamitas), "Use an [i:" + mod.Find<ModItem>("BlightedEyeball").Type + "] at Night"); //7
				bossChecklist.Call("AddBossWithInfo", "Leviathan", 10.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedLeviathan), "By killing an unknown entity in the Ocean Biome"); //8
				bossChecklist.Call("AddBossWithInfo", "Astrum Aureus", 10.55f, (Func<bool>)(() => CalamityWorldPreTrailer.downedAstrageldon), "Use an [i:" + mod.Find<ModItem>("AstralChunk").Type + "] at Night"); //8.25
				bossChecklist.Call("AddBossWithInfo", "Astrum Deus", 10.6f, (Func<bool>)(() => CalamityWorldPreTrailer.downedStarGod), "Use a [i:" + mod.Find<ModItem>("Starcore").Type + "] at Night"); //8.5
				bossChecklist.Call("AddBossWithInfo", "Plaguebringer Goliath", 11.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedPlaguebringer), "Use an [i:" + mod.Find<ModItem>("Abomination").Type + "] in the Jungle Biome"); //9
				bossChecklist.Call("AddBossWithInfo", "Ravager", 12.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedScavenger), "Use an [i:" + mod.Find<ModItem>("AncientMedallion").Type + "]"); //9.5
				//bossChecklist.Call("AddBossWithInfo", "The Old Duke", 13.5f, (Func<bool>)(() => CalamityWorld.downedOldDuke), "Fishing with some type of bait in the Sulphuric Sea"); //9.6
				bossChecklist.Call("AddBossWithInfo", "Profaned Guardians", 14.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedGuardians), "Use a [i:" + mod.Find<ModItem>("ProfanedShard").Type + "] in the Hallow or Underworld Biomes"); //10
				bossChecklist.Call("AddBossWithInfo", "Bumblebirb", 14.6f, (Func<bool>)(() => CalamityWorldPreTrailer.downedBumble), "Use [i:" + mod.Find<ModItem>("BirbPheromones").Type + "] in the Jungle Biome"); //16
				bossChecklist.Call("AddBossWithInfo", "Providence", 15f, (Func<bool>)(() => CalamityWorldPreTrailer.downedProvidence), "Use a [i:" + mod.Find<ModItem>("ProfanedCore").Type + "] in the Hallow or Underworld Biomes"); //11
				bossChecklist.Call("AddBossWithInfo", "Ceaseless Void", 15.1f, (Func<bool>)(() => CalamityWorldPreTrailer.downedSentinel1), "Use a [i:" + mod.Find<ModItem>("RuneofCos").Type + "] in the Dungeon"); //12
				bossChecklist.Call("AddBossWithInfo", "Storm Weaver", 15.2f, (Func<bool>)(() => CalamityWorldPreTrailer.downedSentinel2), "Use a [i:" + mod.Find<ModItem>("RuneofCos").Type + "] in Space"); //13
				bossChecklist.Call("AddBossWithInfo", "Signus", 15.3f, (Func<bool>)(() => CalamityWorldPreTrailer.downedSentinel3), "Use a [i:" + mod.Find<ModItem>("RuneofCos").Type + "] in the Underworld"); //14
				bossChecklist.Call("AddBossWithInfo", "Polterghast", 15.5f, (Func<bool>)(() => CalamityWorldPreTrailer.downedPolterghast), "Use a [i:" + mod.Find<ModItem>("NecroplasmicBeacon").Type + "] in the Dungeon or kill 30 phantom spirits"); //11
				bossChecklist.Call("AddBossWithInfo", "Devourer of Gods", 16f, (Func<bool>)(() => CalamityWorldPreTrailer.downedDoG), "Use a [i:" + mod.Find<ModItem>("CosmicWorm").Type + "]"); //15
				bossChecklist.Call("AddBossWithInfo", "Yharon", 17f, (Func<bool>)(() => CalamityWorldPreTrailer.downedYharon), "Use a [i:" + mod.Find<ModItem>("ChickenEgg").Type + "] in the Jungle Biome"); //17
				bossChecklist.Call("AddBossWithInfo", "Supreme Calamitas", 18f, (Func<bool>)(() => CalamityWorldPreTrailer.downedSCal), "Use an [i:" + mod.Find<ModItem>("EyeofExtinction").Type + "]"); //18
				//bossChecklist.Call("AddBossWithInfo", "MEME GOD", 19f, (Func<bool>)(() => CalamityWorld.downedLORDE), "Use [i:" + mod.ItemType("NO") + "]"); //19
			}
		}

		private static void CensusSupport()
		{
			Mod mod = ModLoader.GetMod("CalamityModClassicPreTrailer");
			
			if (ModLoader.HasMod("Census"))
			{
				Mod censusMod = ModLoader.GetMod("Census");
				censusMod.Call("TownNPCCondition", mod.Find<ModNPC>("SEAHOE").Type, "Defeat a Giant Clam");
				censusMod.Call("TownNPCCondition", mod.Find<ModNPC>("FAP").Type, "Have [i:" + mod.Find<ModItem>("FabsolsVodka").Type + "] in your inventory in Hardmode");
				censusMod.Call("TownNPCCondition", mod.Find<ModNPC>("DILF").Type, "Defeat Cryogen");
			}
		}
	}
}
