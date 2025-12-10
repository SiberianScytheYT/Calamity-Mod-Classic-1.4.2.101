using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace CalamityModClassicPreTrailer.NPCs.Providence
{
    public class HallowProvi : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => Main.LocalPlayer.ZoneHallow && Main.expertMode;
        public bool CanShowItemDropInUI() => Main.expertMode;
        public string GetConditionDescription() => "While in the Hallow";
    }
}