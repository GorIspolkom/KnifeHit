public sealed class PlayerData
{ 
    public double CoinsNumber { get; private set; }

    public PlayerData(double coinsNumber)
    {
        CoinsNumber = coinsNumber;
    }

    public PlayerData()
    {
        CoinsNumber = 0d;
    }

    public void AddCoins(double coins) => CoinsNumber += coins;
    public void SubstractCoins(double coins) => CoinsNumber -= coins;
    public bool IsValide(double coast) => CoinsNumber > coast ? true : false;
}
