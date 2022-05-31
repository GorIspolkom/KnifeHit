public sealed class KnifeKeeper
{
    private readonly KnifePool _knifePool;
    private readonly KnifeThrower _knifeThrower;

    public KnifeKeeper(KnifePool knifePool, KnifeThrower knifeThrower)
    {
        _knifePool = knifePool;
        _knifeThrower = knifeThrower;
    }

    public void ThrowKnife()
    {
        _knifeThrower.ThrowKnife(_knifePool.PrepareKnife());
    }
}
