using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    //目标对象
    public Transform target;
    //相对头顶偏移多少
    public float headOffsetH = 1;
    //倾斜角度
    public float angle = 45;
    //默认的摄像机里观测点的距离
    public float dis = 5;
    //距离必须是3和10之间 
    public float minDis = 3;
    public float maxDis = 10;

    //当前摄像机应该在的位置
    private Vector3 nowPos;
    private Vector3 nowDir;
    private float time;
    private Vector3 startPos;
    private Vector3 endPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //鼠标中键滚动控制摄像机远近的逻辑
        dis += Input.GetAxis("Mouse ScrollWheel");
        dis = Mathf.Clamp(dis, minDis, maxDis);

        //向头顶偏移位置
        nowPos = target.position + target.up * headOffsetH;
        //往后方偏移位置 
        nowDir = Quaternion.AngleAxis(angle, target.right) * -target.forward;
        nowPos = nowPos + nowDir * dis;
        //直接把算出来的位置赋值
        if(endPos != nowPos) 
        { 
            startPos = this.transform.position;
            endPos = nowPos;
            time = 0;
        }
        time += Time.deltaTime;
        //this.transform.position = nowPos;
        //先快后慢
        //this.transform.position = Vector3.Lerp(this.transform.position,nowPos,Time.deltaTime*dis);
        //匀速
        this.transform.position = Vector3.Lerp(startPos, endPos, time);

        Quaternion.LookRotation(nowDir);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(-nowDir),Time.deltaTime);
        
    }
}
