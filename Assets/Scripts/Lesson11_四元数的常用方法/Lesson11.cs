using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    public Transform testObj;
    public Transform target;
    public Transform A;
    public Transform B;

    private Quaternion start;
    private float time;
    public Transform lookA;
    public Transform lookB; 

    // Start is called before the first frame update
    void Start()
    {
        #region ��λ��Ԫ��
        //print(Quaternion.identity);
        //testObj.rotation = Quaternion.identity;
        //��ʼ������ʱ���ܻ�������ֵ
        //Instantiate(testObj,Vector3.zero,Quaternion.identity);
        #endregion
        start = B.rotation;

        #region ��ֵ����
        //��Ԫ����Ҳ�ṩ����ͬVector3�Ĳ�ֵ����
        //Lerp��Slerp

        //����Ԫ����Lerp��Slerpֻ��һЩϸ΢�Ĳ��
        //�����㷨��ͬ
        //Slerp��Ч�����һЩ
        //Lerp��Ч�����Slerp��Ч�����쵫�������ת��Χ�ϴ�Ч����ϲ�
        //���Խ���ʹ��Slerp����ֵ����
        #endregion

        Quaternion q = Quaternion.LookRotation(lookB.position - lookA.position);
        lookA.rotation = q;
    }

    // Update is called once per frame
    void Update()
    {
        //�ȿ�������޽ӽ�
        A.transform.rotation = Quaternion.Slerp(A.rotation, target.rotation, Time.deltaTime);

        //���ٱ仯
        time += Time.deltaTime;
        B.rotation = Quaternion.Slerp(start, target.rotation, time);

        #region ����ָ����Ԫ��
        Quaternion q = Quaternion.LookRotation(lookB.position - lookA.position);
        lookA.rotation = q;
        #endregion


    }
}
