using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 一 什么是延迟函数
        // 延迟函数顾名思义就是会延迟执行的函数，我们可以自己设定延时要执行的函数和具体延时的时间。是MonoBehaviour基类中实现的好方法
        #endregion
        #region 二 延迟函数的使用
        //1.延迟函数
        //Invoke
        //参数一：函数名 字符串
        //参数二：延迟时间 秒为单位
        Invoke("Test", 5);
        //注意：
        //1-1.延时函数第一个参数传入的是函数名字字符串
        //1-2.延时函数没办法传入参数 只有包裹一层
        //1-3.函数名必须是该脚本上申明的函数

        //2.延迟重复执行函数
        //InvokeRepeating
        //参数一：函数名字字符串
        //参数二：第一次执行的延迟时间
        //参数三：之后每次执行的间隔时间
        InvokeRepeating("ReTest", 2, 1);

        //注意事项和延迟函数相同

        //3.取消延迟函数
        //3-1取消该脚本上所有延迟函数的执行
        //CancelInvoke();

        //3-2 取消指定延迟函数的执行

        //CancelInvoke("ReTest");
        //同一个函数不管开启多少个延迟，都会被取消指定延迟函数全部取消执行

        //4.判断是否又延迟函数
        if (IsInvoking())
        {
            print("存在延迟函数");
        }
        else if (IsInvoking("ReTest"))
        {
            print("存在ReTest延迟函数");
        }

        #endregion

        #region 延迟函数受对象失活销毁的影响
        //脚本依附对象失活 或者脚本自己失活
        //延迟函数可以继续执行

        //脚本依附对象被销毁 或者脚本被移除
        //延迟函数无法继续执行
        #endregion

        #region 总结
        //继承MonoBehavior的脚本可以使用延迟相关函数
        //函数相关
        //Invoke 延时函数
        //InvokeRepeatinng 延迟重复函数
        //CancelInvoke 停止所有或者停止传入的指定延时函数
        //IsInvoke 判断是否有延迟函数在执行
        //使用相关
        //1.参数都是函数名，无法传函数需要的参数
        //2.只能执行该脚本中申明的函数
        //3.对象或脚本失活无法停止延时函数执行，只有销毁组件或者对象才会停止或者代码停止

        #endregion
    }
    private void Test()
    {
        print("延迟执行");
    }

    private void ReTest()
    {
        print("延迟重复执行");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
