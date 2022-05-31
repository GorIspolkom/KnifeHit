using TMPro;

public sealed class RewardedItemCounter
{
    private TMP_Text _itemsText;

    public RewardedItemCounter(TMP_Text itemsText, double itemsCount = 0d)
    {
        _itemsText = itemsText;
        UpdateText(itemsCount);
    }

    public void UpdateText(double itemsCount)
    {
        _itemsText.text = itemsCount.ToString();
    }
}
