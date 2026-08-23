using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace CalamityModClassicPreTrailer.NPCs.NPCLootConditions.MiscConditions;

public class ArmageddonDropRuleCondition : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.armageddon;
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.armageddon;
    public string GetConditionDescription() => null;
}

public class DeathCondition : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.death;
        
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.death;
        
    public string GetConditionDescription() => null;
}

public class DefiledCondition : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.defiled;
        
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.defiled;
        
    public string GetConditionDescription() => null;
}

public class FVodkaCondition : IItemDropRuleCondition
{
    Player player = Main.LocalPlayer;
    public bool CanDrop(DropAttemptInfo info) => player.GetModPlayer<CalamityPlayerPreTrailer>().fabsolVodka;
        
    public bool CanShowItemDropInUI() => player.GetModPlayer<CalamityPlayerPreTrailer>().fabsolVodka;
        
    public string GetConditionDescription() => null;
}

public class HardcorePlayerCondition : IItemDropRuleCondition
{
    Player player = Main.LocalPlayer;
    public bool CanDrop(DropAttemptInfo info) => player.difficulty == 2;
    public bool CanShowItemDropInUI() => player.difficulty == 2;
    public string GetConditionDescription() =>"If playing with a Hardcore character";
}

public class RevCondition : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info) => CalamityWorldPreTrailer.revenge;
        
    public bool CanShowItemDropInUI() => CalamityWorldPreTrailer.revenge;
        
    public string GetConditionDescription() => null;
}