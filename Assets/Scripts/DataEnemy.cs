using UnityEngine;

[CreateAssetMenu(menuName ="LanSheep/Data Enemy")]
public class DataEnemy : DataBasic
{

    [Header("ExpProbabilty"), Range(0, 1)]
    public float expProbabilty;
    [Header("PrefabExp")]
    public GameObject prefabExp;
}
