using UnityEngine;

[CreateAssetMenu(menuName = "LanSheep/Data Basic")]
public class DataBasic : ScriptableObject
{
    [Header("HP"), Range(0, 10000)]
    public float hp;
    [Header("ATTACK"), Range(0, 10000)]
    public float attack;
    [Header("SPEED"), Range(0, 100)]
    public float movespeed;
}
