using UnityEngine;

[CreateAssetMenu(fileName = "RageData", menuName = "ScriptableObjects/RageData", order = 1)]
public class RageScoreData : ScriptableObject
{
    public int rageValue;

    public void GenerateRandomRage()
    {
        rageValue = Random.Range(8, 11); // 11 не включается, так что диапазон 8-10
    }
}