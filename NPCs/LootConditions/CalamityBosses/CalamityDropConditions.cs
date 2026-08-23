using Terraria;
using CalamityModClassicPreTrailer.NPCs.SlimeGod;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer.NPCs.NPCLootConditions.CalamityBosses;

public class BuffedEclipseActive : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.buffedEclipse;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.buffedEclipse;
    public string GetConditionDescription() => null;
}

public class CanGetPurifiedJam : IItemDropRuleCondition
{
    public static NPC npc;
    public CanGetPurifiedJam(NPC _npc)
    {
        npc = _npc;
    }
    
    public bool CanDrop(DropAttemptInfo info) => !Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<CalamityPlayerPreTrailer>().revJamDrop;
    public bool CanShowItemDropInUI() => !Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<CalamityPlayerPreTrailer>().revJamDrop;
    public string GetConditionDescription() => null;
}

public class DownedAstrumDeus : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedStarGod;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.downedStarGod;
    public string GetConditionDescription() => null;
}

public class DownedCalDoppelorPlantera : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => NPC.downedPlantBoss || CalamityWorldPreTrailer.downedCalamitas;
    public bool CanShowItemDropInUI() => NPC.downedPlantBoss || CalamityWorldPreTrailer.downedCalamitas;
    public string GetConditionDescription() => null;
}

public class DownedCeaseless : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedSentinel1;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedSentinel1;
    public string GetConditionDescription() => null;
}

public class DownedDoG : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedDoG;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.downedDoG;
    public string GetConditionDescription() => null;
}

public class DownedDS : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedDesertScourge;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.downedDesertScourge;
    public string GetConditionDescription() => null;
}

public class DownedPolterghast : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedPolterghast;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.downedPolterghast;
    public string GetConditionDescription() => null;
}

public class DownedSCal : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedSCal;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.downedSCal;
    public string GetConditionDescription() => null;
}

public class DownedSignus : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedSentinel3;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedSentinel3;
    public string GetConditionDescription() => null;
}

public class DownedStormWeaver : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedSentinel2;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedSentinel2;
    public string GetConditionDescription() => null;
}

public class NotDownedAquaticScourge : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedAquaticScourge;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedAquaticScourge;
    public string GetConditionDescription() => null;
}

public class NotDownedAstrumDeus : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedStarGod;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedStarGod;
    public string GetConditionDescription() => null;
}

public class NotDownedAureus : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedAstrageldon;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedAstrageldon;
    public string GetConditionDescription() => null;
}

public class NotDownedBrimstoneElemental : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedBrimstoneElemental;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedBrimstoneElemental;
    public string GetConditionDescription() => null;
}

public class NotDownedBumblebirb : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedBumble;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedBumble;
    public string GetConditionDescription() => null;
}

public class NotDownedCalDoppel : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedCalamitas;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedCalamitas;
    public string GetConditionDescription() => null;
}

public class NotDownedCrabulon : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedCrabulon;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedCrabulon;
    public string GetConditionDescription() => null;
}

public class NotDownedCryogen : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedCryogen;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedCryogen;
    public string GetConditionDescription() => null;
}

public class NotDownedDoG : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedDoG;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedDoG;
    public string GetConditionDescription() => null;
}

public class NotDownedDS : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedDesertScourge;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedDesertScourge;
    public string GetConditionDescription() => null;
}

public class NotDownedGuardians : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedGuardians;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedGuardians;
    public string GetConditionDescription() => null;
}

public class NotDownedHiveMind : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedHiveMind;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedHiveMind;
    public string GetConditionDescription() => null;
}
public class NotDownedLeviathan : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedLeviathan;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedLeviathan;
    public string GetConditionDescription() => null;
}

public class NotDownedPBG : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedPlaguebringer;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedPlaguebringer;
    public string GetConditionDescription() => null;
}

public class NotDownedPerforators : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedPerforator;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedPerforator;
    public string GetConditionDescription() => null;
}

public class NotDownedPolterghast : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedPolterghast;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedPolterghast;
    public string GetConditionDescription() => null;
}

public class DownedProvidence : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.downedProvidence;
    public bool CanShowItemDropInUI() => true;
    public string GetConditionDescription() =>  "After defeating Providence";
}

public class NotDownedProvidence : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedProvidence;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedProvidence;
    public string GetConditionDescription() => null;
}

public class NotDownedRavager : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedScavenger;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedScavenger;
    public string GetConditionDescription() => null;
}

public class NotDownedSCal : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedSCal;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedSCal;
    public string GetConditionDescription() => null;
}

public class NotDownedSlimeGod : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedSlimeGod;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedSlimeGod;
    public string GetConditionDescription() => null;
}

public class NotDownedYharon : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedYharon;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedYharon;
    public string GetConditionDescription() => null;
}

public class NotInDoGSentinelPhase : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.DoGSecondStageCountdown <= 0;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.DoGSecondStageCountdown <= 0;
    public string GetConditionDescription() => null;
}

public class SpecialSCalItem : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => Main.LocalPlayer.GetModPlayer<CalamityPlayerPreTrailer>().sCalDeathCount == 3;
    public bool CanShowItemDropInUI() => Main.LocalPlayer.GetModPlayer<CalamityPlayerPreTrailer>().sCalDeathCount == 3;
    public string GetConditionDescription() => null;
}

#region SpecialSlimeGodDropRules
public class CorePresent : IItemDropRuleCondition
{
    private NPC npc;
    public CorePresent(NPC _npc) { npc = _npc; }

    public bool CanDrop(DropAttemptInfo info) => npc.type == ModContent.NPCType<SlimeGodCore>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodSplit>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRunSplit>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGod.SlimeGod>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRun>());
    public bool CanShowItemDropInUI() => npc.type == ModContent.NPCType<SlimeGodCore>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodSplit>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRunSplit>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGod.SlimeGod>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRun>());
    public string GetConditionDescription() => null;
}

public class EbonianPresent : IItemDropRuleCondition
{
    private NPC npc;
    public EbonianPresent(NPC _npc) { npc = _npc; }

    public bool CanDrop(DropAttemptInfo info) => npc.type == ModContent.NPCType<SlimeGodSplit>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodCore>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRunSplit>()) && NPC.CountNPCS(ModContent.NPCType<SlimeGodSplit>()) < 2 && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRun>());
    public bool CanShowItemDropInUI() => npc.type == ModContent.NPCType<SlimeGodSplit>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodCore>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRunSplit>()) && NPC.CountNPCS(ModContent.NPCType<SlimeGodSplit>()) < 2 && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodRun>());
    public string GetConditionDescription() => null;
}

public class CrimulanPresent : IItemDropRuleCondition
{
    private NPC npc;
    public CrimulanPresent(NPC _npc) { npc = _npc; }

    public bool CanDrop(DropAttemptInfo info) => npc.type == ModContent.NPCType<SlimeGodRunSplit>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodCore>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodSplit>()) && NPC.CountNPCS(ModContent.NPCType<SlimeGodRunSplit>()) < 2 && !NPC.AnyNPCs(ModContent.NPCType<SlimeGod.SlimeGod>());
    public bool CanShowItemDropInUI() => npc.type == ModContent.NPCType<SlimeGodRunSplit>() && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodCore>()) && !NPC.AnyNPCs(ModContent.NPCType<SlimeGodSplit>()) && NPC.CountNPCS(ModContent.NPCType<SlimeGodRunSplit>()) < 2 && !NPC.AnyNPCs(ModContent.NPCType<SlimeGod.SlimeGod>());
    public string GetConditionDescription() => null;
}
#endregion