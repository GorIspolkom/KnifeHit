using UnityEngine;

public struct KnifeSpawnerData
{
    public Knife knife;
    public Vector3 spawnCoordinate;

    public KnifeSpawnerData(Knife knife, Vector3 spawnCoordinate)
    {
        this.knife = knife;
        this.spawnCoordinate = spawnCoordinate;
    }
}

public sealed class KnifeSpawner : ISpawner
{
    private readonly KnifeSpawnerData _knifeSpawnerData;

    public KnifeSpawner(KnifeSpawnerData knifeSpawnerData)
    {
        _knifeSpawnerData = knifeSpawnerData;
    }

    public Knife Spawn()
    {
        return Object.Instantiate(_knifeSpawnerData.knife, 
            _knifeSpawnerData.spawnCoordinate, Quaternion.identity, null);
    }
}
