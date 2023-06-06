using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [Header("生成間隔"), Range(0, 10)]
    public float interval = 3.5f;

    [Header("生成武器區域")]
    public GameObject prefabWeapon;

    private void SpawnWeapon()
    {
        Instantiate(prefabWeapon, transform.position, transform.rotation);
    }
}
