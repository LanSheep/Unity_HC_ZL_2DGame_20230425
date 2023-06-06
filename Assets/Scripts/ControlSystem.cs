using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0, 10)]
    public float moveSpeed = 3.5f;

    [Header("剛體")]
    public Rigidbody2D rig;

    [Header("動畫控制器")]
    public Animator ani;

    [Header("跑步參數")]
    public string parRun = "walk switch";

    //起始資料
    private void Awake()
    {
        //print(123);
        //print("1+2");
        //print($"{ 1 + 2}");
    }

    private void Start()
    {
        //print("<color=red>開始事件</color>");

    }

    private void Update()
    {
        //print("<color=#EAC100>更新事件</color>");
        //呼叫move
        Move();
    }

    private void Move()
    {
        //取得控制輸入值
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

            //設置物體的速度
            rig.velocity = new Vector2(h, v) * moveSpeed;
        
        ani.SetBool(parRun, h != 0 || v != 0);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        
            }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }


    }
}
