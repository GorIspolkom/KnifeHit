using TMPro;

public sealed class KnifesThrowCounter
{
    private TMP_Text _knifesText;

    public KnifesThrowCounter(TMP_Text knifesText, double knifesCount = 0d)
    {
        _knifesText = knifesText;
        UpdateText(knifesCount);
    }

    public void UpdateText(double knifesCount)
    {
        _knifesText.text = knifesCount.ToString();
    }
}
