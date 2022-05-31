public sealed class PurposeMediator
{
    private readonly UIPool _uIPool;
    private readonly LevelLoader _levelLoader;
    private readonly PurposePool _purposePool;
    private readonly KnifePool _knifePool;

    public PurposeMediator(UIPool uIPool, LevelLoader levelLoader, PurposePool purposePool, KnifePool knifePool)
    {
        _uIPool = uIPool;
        _levelLoader = levelLoader;
        _purposePool = purposePool;
        _knifePool = knifePool;
    }

    public void Notify(Purpose purpose)
    {

    }
}
