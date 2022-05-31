public struct UICounters
{
    public KnifesThrowCounter knifesThrowCounter;
    public RewardedItemCounter rewardedItemCounter;

    public UICounters(KnifesThrowCounter knifesThrowCounter, RewardedItemCounter rewardedItemCounter)
    {
        this.knifesThrowCounter = knifesThrowCounter;
        this.rewardedItemCounter = rewardedItemCounter;
    }
}

public sealed class UIPool
{
    public readonly UICounters uICounters;

    public UIPool(UICounters uICounters)
    {
        this.uICounters = uICounters;
    }
}
