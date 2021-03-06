﻿namespace Codeplay
{
    public interface IRewardDelegate
    {
        IItem GetRelatedItem(string itemId);
        void Give(Reward reward);
        void Take(Reward reward);
    }
}