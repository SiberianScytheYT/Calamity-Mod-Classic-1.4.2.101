using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace CalamityModClassicPreTrailer.NPCs.NPCLootConditions;

public class CelestialPillarsNotPresent : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.LunarApocalypseIsUp;
    public bool CanShowItemDropInUI() => !NPC.LunarApocalypseIsUp;
    public string GetConditionDescription() => null;
}

public class CorruptionVSCrimson : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => WorldGen.crimson;
    public bool CanShowItemDropInUI() => WorldGen.crimson;
    public string GetConditionDescription() => null;
}

public class DownedGolem : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => NPC.downedGolemBoss;
    public bool CanShowItemDropInUI() => NPC.downedGolemBoss;
    public string GetConditionDescription() => null;
}

public class DownedMoonLord : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => NPC.downedMoonlord;
    public bool CanShowItemDropInUI() => NPC.downedMoonlord;
    public string GetConditionDescription() => null;
}

public class DownedSkeletron : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => NPC.downedBoss3;
    public bool CanShowItemDropInUI() => NPC.downedBoss3;
    public string GetConditionDescription() => null;
}

public class NoDownedMechBosses : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBossAny;
    public bool CanShowItemDropInUI() => !NPC.downedMechBossAny;
    public string GetConditionDescription() => null;
}

public class NotDownedBetsy : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedBetsy;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedBetsy;
    public string GetConditionDescription() => null;
}

public class NotDownedCultist : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedAncientCultist;
    public bool CanShowItemDropInUI() => !NPC.downedAncientCultist;
    public string GetConditionDescription() => null;
}

public class NotDownedDestroyer : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss1;
    public bool CanShowItemDropInUI() => !NPC.downedMechBoss1;
    public string GetConditionDescription() => null;
}

public class NotDownedDuke : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedFishron;
    public bool CanShowItemDropInUI() => !NPC.downedFishron;
    public string GetConditionDescription() => null;
}

public class NotDownedEvilBoss : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedWhar;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedWhar;
    public string GetConditionDescription() => null;
}

public class NotDownedEye : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedBoss1;
    public bool CanShowItemDropInUI() => !NPC.downedBoss1;
    public string GetConditionDescription() => null;
}

public class NotDownedGolem : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedGolemBaby;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedGolemBaby;
    public string GetConditionDescription() => null;
}

public class NotDownedKS : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedSlimeKing;
    public bool CanShowItemDropInUI() => !NPC.downedSlimeKing;
    public string GetConditionDescription() => null;
}

public class NotDownedMoonLord : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !CalamityWorldPreTrailer.downedMoonDude;
    public bool CanShowItemDropInUI() => !CalamityWorldPreTrailer.downedMoonDude;
    public string GetConditionDescription() => null;
}

public class NotDownedPlantera : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedPlantBoss;
    public bool CanShowItemDropInUI() => !NPC.downedPlantBoss;
    public string GetConditionDescription() => null;
}

public class NotDownedPrime : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss3;
    public bool CanShowItemDropInUI() => !NPC.downedMechBoss3;
    public string GetConditionDescription() => null;
}

public class NotDownedQB : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedQueenBee;
    public bool CanShowItemDropInUI() => !NPC.downedQueenBee;
    public string GetConditionDescription() => null;
}

public class NotDownedSkeletron : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedBoss3;
    public bool CanShowItemDropInUI() => !NPC.downedBoss3;
    public string GetConditionDescription() => null;
}

public class NotDownedTwins : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss2;
    public bool CanShowItemDropInUI() => !NPC.downedMechBoss2;
    public string GetConditionDescription() => null;
}