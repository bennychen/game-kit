﻿public class UpgradeItemDelegate : NonConsumableDelegate
{
    public override bool CanBuyNow(VirtualItem item) 
    {
        VirtualItem associatedItem = item.RelatedItem;
        VirtualItem nextUpgradeItem = associatedItem.NextUpgradeItem;
        return nextUpgradeItem != null && nextUpgradeItem == item;
    }

    public override void Give(VirtualItem item, int amount)
    {
        Storage.SetGoodCurrentLevel(item.RelatedItemID,
            Storage.GetGoodCurrentLevel(item.RelatedItemID) + 1);
    }

    public override void Take(VirtualItem item, int amount)
    {
        Storage.SetGoodCurrentLevel(item.RelatedItemID,
            Storage.GetGoodCurrentLevel(item.RelatedItemID) - 1);
    }

    public override int GetCurrentLevel(VirtualItem item)
    {
        return 0;
    }
}