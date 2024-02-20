using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Mathf和Math
        //Math是C#中封装好的用于数学计算的工具类 ——位于Ststem命名空间中
        //Mathf是Unity中封装好的用于数学计算的工具结构体 —— 位于UnityEngine命名空间中
        //他们都是提供用于进行数学相关计算的 
        #endregion

        #region 知识点二 他们的区别
        //Mathf 和 Math中的相关方法几乎一样
        //Math 是C#自带的工具类 主要提供一些数学相关计算方法
        //Mathf 是Unity专门封装的， 不仅包含Math中的方法，还多了一些适用于游戏开发的方法
        //所以我们在进行Unity开发时
        //使用Mathf方法用于数学计算即可
        #endregion

        #region 知识点三 Mathf中常用的方法——一般计算一次
        //1.Π - PI
        print(Mathf.PI);

        //2.取绝对值 - Abs
        print(Mathf.Abs(-10));

        //3.向上取整 - CeilToInt
        float f = 0.5f;
        int i = (int)f; //这种只能向下取整
        print(Mathf.CeilToInt(1.3f));

        //4.向下取整 - FloorToInt
        print(Mathf.FloorToInt(i));

        //5.钳制函数 - Clamp
        print(Mathf.Clamp(10,11,20));//如果比最小的还要小，就取最小值
        print(Mathf.Clamp(21,11,20));//如果比最大的还要大，取最大值
        print(Mathf.Clamp(15,11,20));//如果在最大值和最小值之间，取自己本身

        //6.获取最大值 - Max
        int[] arys = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        print("最大的值是：" + Mathf.Max(arys));

        //7.获取最小值 - Min
        print(Mathf.Min(arys));

        //8.一个数的n次幂 - Pow
        print("一个数的N次方:" + Mathf.Pow(4,2));
        print("一个数的N次方:" + Mathf.Pow(2,3));

        //9.四舍五入 - RoundToInt
        print(Mathf.RoundToInt(1.6f));
        print(Mathf.RoundToInt(1.3f));


        //10.返回一个数的平方根 - Sqrt
        print(Mathf.Sqrt(4));
        print(Mathf.Sqrt(8));


        //11.判断一个数是否是2的n次方 - IsPowerOfTwo
        print(Mathf.IsPowerOfTwo(5));
        print(Mathf.IsPowerOfTwo(8));

        
        //12.判断正负数 - Sign

        print(Mathf.Sign(4));//正数返回1 负数返回-1 0是正数

        #endregion
    }
    float start = 0;
    float result = 0;
    float time = 0;
    // Update is called once per frame
    void Update()
    {

        #region 知识点四 Mathf中的常用方法——一般不停计算
        //插值运算 - Lerp
        //Lerp函数公式：result = Mathf.Lerp(start , end , t);

        start = Mathf.Lerp(start, 10, Time.deltaTime);

        //t为插值系数， 取值范围为0-1 
        //result = start + （end - start）* t

        //插值运算用法一 
        //每帧改变 start 的值——变化速度先快后慢 ， 位置无限接近 ， 但是不会得到 end 位置

        //插值运算用法二
        //每帧改变t的值——变化速度匀速， 位置每帧接近 当t >= 1 时 ，得到结果
        time += Time.deltaTime;
        result = Mathf.Lerp(start, 10, time);


        #endregion
    }
}
