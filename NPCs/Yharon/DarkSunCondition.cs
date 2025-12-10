using Terraria;
using Terraria.GameContent.ItemDropRules;
namespace CalamityModClassicPreTrailer.NPCs.Yharon;

public class DarkSunCondition : IItemDropRuleCondition
{
    public static NPC npc;
    public DarkSunCondition(NPC _npc)
    {
        npc = _npc;
    }

    public bool CanDrop(DropAttemptInfo info) => npc.localAI[2] == 1f;
    public bool CanShowItemDropInUI() => npc.localAI[2] == 1f;
    public string GetConditionDescription() => null;
}