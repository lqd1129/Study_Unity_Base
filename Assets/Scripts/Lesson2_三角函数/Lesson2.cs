using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 弧度、角度互相转化
        //弧度转角度
        float rad = 1;
        float anger = rad * Mathf.Rad2Deg;

        //角度转弧度
        anger = 1;
        rad = anger * Mathf.Deg2Rad;

        #endregion

        #region 知识点二 三角函数
        //注意: Mathf中的三角函数相关函数，传入的参数需要是弧度值
        print(Mathf.Sin(30 * Mathf.Deg2Rad));
        print(Mathf.Cos(30 * Mathf.Deg2Rad));
        print(Mathf.Cos(60 * Mathf.Deg2Rad));

        #endregion

        #region 知识点三 反三角函数
        //作用 通过反三角函数计算正弦或余弦值对应的弧度值
        //注意 ： 反三角函数得到的结果是 正弦或余弦值对应的弧度
        rad = Mathf.Asin(0.5f);
        print(rad * Mathf.Rad2Deg);
        rad = Mathf.Acos(0.5f);
        print(rad * Mathf.Rad2Deg);



        #endregion
    }

    
}
