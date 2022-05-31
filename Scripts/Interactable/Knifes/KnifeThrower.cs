using UnityEngine;

public struct ThrowData
{
    public float velocity;
    public Vector3 throwDirection;

    public ThrowData(float velocity, Vector3 throwDirection)
    {
        this.velocity = velocity;
        this.throwDirection = throwDirection;
    }
}

public sealed class KnifeThrower
{
    private readonly ThrowData _throwData;

    public KnifeThrower(ThrowData throwData)
    {
        _throwData = throwData;
    }

    public void ThrowKnife(Knife knife)
    {
        knife.Throw(_throwData.throwDirection, _throwData.velocity);
    }
}
