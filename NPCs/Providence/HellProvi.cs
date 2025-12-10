using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace CalamityModClassicPreTrailer.NPCs.Providence
{
    public class HellProvi : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => Main.LocalPlayer.ZoneUnderworldHeight && Main.expertMode;
        public bool CanShowItemDropInUI() => Main.expertMode;
        public string GetConditionDescription() => "While in the Underworld";
    }
}