using UnityEngine;

[CreateAssetMenu(fileName = "StageData", menuName = "ScriptableObjects/StageData", order = 2)]
public class StageData : ScriptableObject
{
    public Purpose purpose;
    public int knifesNumber;
}
