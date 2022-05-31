public sealed class KnifePool
{
    private Knife[,] _knifes;
    private readonly KnifeSpawner _knifeSpawner;

    public int StageKnifeCounts { get; private set;}
    public int CurrentKnifeCount { get; private set; }
    public int CurrentStage { get; private set; }

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

    public Knife PrepareKnife()
    {
        Knife knife = _knifes[CurrentStage, CurrentKnifeCount];
        CurrentKnifeCount++;
        return knife;
    }
}
