using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifePool
{
    private Knife[,] _knifes;
    private readonly KnifeSpawner _knifeSpawner;

    public KnifePool(LevelData levelData, KnifeSpawner knifeSpawner)
    {
        _knifeSpawner = knifeSpawner;
        InitKnifes(levelData);
    }

    public void InitKnifes(LevelData levelData)
    {
        _knifes = new Knife[levelData.stageDatas.Length,
            levelData.stageDatas[0].knifesNumber];

        for (int i = 0; i < levelData.stageDatas.Length; i++)
            for (int j = 0; j < levelData.stageDatas[0].knifesNumber; i++)
                _knifes[i, j] =  _knifeSpawner.Spawn();
    }
}
