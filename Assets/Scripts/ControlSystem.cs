using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    private void Awake()
    {
        print(123);
        print("1+2");
        print($"{ 1 + 2}");
    }

    private void Start()
    {
        print("<color=red>開始事件</color>");

    }

    private void Update()
    {
        print("<color=#EAC100>更新事件</color>");

    }
}
