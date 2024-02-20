using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    //Ŀ�����
    public Transform target;
    //���ͷ��ƫ�ƶ���
    public float headOffsetH = 1;
    //��б�Ƕ�
    public float angle = 45;
    //Ĭ�ϵ��������۲��ľ���
    public float dis = 5;
    //���������3��10֮�� 
    public float minDis = 3;
    public float maxDis = 10;

    //��ǰ�����Ӧ���ڵ�λ��
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
        //����м��������������Զ�����߼�
        dis += Input.GetAxis("Mouse ScrollWheel");
        dis = Mathf.Clamp(dis, minDis, maxDis);

        //��ͷ��ƫ��λ��
        nowPos = target.position + target.up * headOffsetH;
        //����ƫ��λ�� 
        nowDir = Quaternion.AngleAxis(angle, target.right) * -target.forward;
        nowPos = nowPos + nowDir * dis;
        //ֱ�Ӱ��������λ�ø�ֵ
        if(endPos != nowPos) 
        { 
            startPos = this.transform.position;
            endPos = nowPos;
            time = 0;
        }
        time += Time.deltaTime;
        //this.transform.position = nowPos;
        //�ȿ����
        //this.transform.position = Vector3.Lerp(this.transform.position,nowPos,Time.deltaTime*dis);
        //����
        this.transform.position = Vector3.Lerp(startPos, endPos, time);

        Quaternion.LookRotation(nowDir);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(-nowDir),Time.deltaTime);
        
    }
}
