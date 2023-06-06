using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [Header("生成間隔"), Range(0, 10)]
    public float interval = 3.5f;

    [Header("生成怪物區域")]
    public GameObject prefabenmy;

    private void SpawnEnemy()
    {
        Instantiate(prefabenmy, transform.position, transform.rotation);
    }

    private void Awake()
    {
        //SpawnEnemy
        InvokeRepeating("SpawnEnemy", 0, interval);

    }
}
