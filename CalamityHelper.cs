using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityModClassicPreTrailer;

public static class CalamityHelper
{
    public static NPCShop AddWithCustomValue(this NPCShop shop, int itemType, int customValue, params Condition[] conditions)
    {
        var item = new Item(itemType)
        {
            shopCustomPrice = customValue
        };
        return shop.Add(item, conditions);
    }
    public static Condition Create(string key, Func<bool> predicate)
    {
        return new Condition(
            Language.GetText($"Mods.CalamityModClassicPreTrailer.Condition.{key}"),
            predicate
        );
    }
    public static IItemDropRule PerPlayer(int itemID, int denominator = 1, int minQuantity = 1, int maxQuantity = 1, int numerator = 1)
    {
        return new PerPlayerDropRule(itemID, denominator, minQuantity, maxQuantity, numerator);
    }
}

// code taken from DropHelper
public class PerPlayerDropRule : CommonDrop
{
    // Calamity Classic 1.4.2 defaults this to vanilla's 15 minutes, to be period accurate.
    private const int DefaultDropProtectionTime = 54000; // 15 minutes
    private int protectionTime;
    
    public PerPlayerDropRule(int itemID, int denominator = 1, int minQuantity = 1, int maxQuantity = 1, int numerator = 1, int protectFrames = DefaultDropProtectionTime)
                : base(itemID, denominator, minQuantity, maxQuantity, numerator)
    {
        protectionTime = protectFrames;
    }
    
    public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
    { 
        ItemDropAttemptResult result = default;
        if (info.rng.Next(chanceDenominator) < chanceNumerator)
        {
            int stack = info.rng.Next(amountDroppedMinimum, amountDroppedMaximum + 1);
            TryDropInternal(info, itemId, stack);
            result.State = ItemDropAttemptResultState.Success;
            return result;
        }

        result.State = ItemDropAttemptResultState.FailedRandomRoll;
        return result;
    }

    // The contents of this method are more or less copied from CommonCode.DropItemLocalPerClientAndSetNPCMoneyTo0
    private void TryDropInternal(DropAttemptInfo info, int itemId, int stack)
    {
        if (itemId <= 0 || itemId >= ItemLoader.ItemCount)
            return;

        // If server-side, then the item must be spawned for each client individually.
        if (Main.netMode == NetmodeID.Server)
        {
            NPC npc = info.npc;
            int idx = Item.NewItem(npc.GetSource_Loot(), npc.Center, itemId, stack, true, -1);
            Main.timeItemSlotCannotBeReusedFor[idx] = protectionTime;
            for (int i = 0; i < Main.maxPlayers; ++i)
                if (Main.player[i].active)
                    NetMessage.SendData(MessageID.InstancedItem, i, -1, null, idx);
            Main.item[idx].active = false;
        }
        // Otherwise just drop the item.
        else
            CommonCode.DropItem(info, itemId, stack);
    }
}
