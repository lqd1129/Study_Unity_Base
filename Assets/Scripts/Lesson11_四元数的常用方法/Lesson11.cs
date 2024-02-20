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
        #region 单位四元数
        //print(Quaternion.identity);
        //testObj.rotation = Quaternion.identity;
        //初始化对象时可能会用来赋值
        //Instantiate(testObj,Vector3.zero,Quaternion.identity);
        #endregion
        start = B.rotation;

        #region 插值运算
        //四元数中也提供了如同Vector3的插值运算
        //Lerp和Slerp

        //在四元数中Lerp和Slerp只有一些细微的差别
        //由于算法不同
        //Slerp的效果会好一些
        //Lerp的效果相比Slerp的效果更快但是如果旋转范围较大，效果会较差
        //所以建议使用Slerp做插值运算
        #endregion

        Quaternion q = Quaternion.LookRotation(lookB.position - lookA.position);
        lookA.rotation = q;
    }

    // Update is called once per frame
    void Update()
    {
        //先快后慢无限接近
        A.transform.rotation = Quaternion.Slerp(A.rotation, target.rotation, Time.deltaTime);

        //匀速变化
        time += Time.deltaTime;
        B.rotation = Quaternion.Slerp(start, target.rotation, time);

        #region 向量指向四元数
        Quaternion q = Quaternion.LookRotation(lookB.position - lookA.position);
        lookA.rotation = q;
        #endregion


    }
}
