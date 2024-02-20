using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public Thread t;
    //申明一个变量作为一个公共的内存容器
    Queue<Vector3> queue = new Queue<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        #region 一 Unity是否支持多线程
        //首先要明确一点
        //Unity是否支持多线程
        //只是新开线程无法访问Unity相关对象的内容

        //注意 ： Unity中的多线程 要记得关闭
        t = new Thread(Test);
        //t.Start();

        //用处：在进行一些寻路算法运算以及网络通信相关内容时，可能会导致主线程卡顿，这个时候使用副线程来处理
        #endregion
        #region 二 协同程序是什么
        //协同程序简称协程
        //它是"假"的多线程 ，它不是多线程

        //主要作用
        //将代码分时执行，不卡主线程
        //简单理解，是吧可能会让主线程卡顿的耗时逻辑分时分步执行

        //主要使用的场景：
        //异步加载文件
        //异步下载文件
        //场景异步加载
        //批量创建时防止卡顿
        #endregion
        #region 三 协同程序和线程的区别
        //新开一个线程是独立的一个管道，和主线程并行执行
        //新开一个协程是在原线程之上开启，进行逻辑分时分布执行
        #endregion
        #region 四 协程的使用
        //继承MonoBehavior的类 都可以开启 协程函数
        //第一步：申明协程函数
        // 协程函数2个关键点
        // 1-1 返回值为IEnumerator类型及其子类
        // 1-2函数中通过 yield return 返回值；并进行返回

        //第二步：开启协程函数
        //协程函数不能直接去执行
        //MyCoroutine(1, "123");
        //常用开启方式
        Coroutine  c1 = StartCoroutine(MyCoroutine(1, "123"));
        Coroutine  c2 = StartCoroutine(MyCoroutine(1, "123"));
        Coroutine  c3 = StartCoroutine(MyCoroutine(1, "123"));

        //第三步：关闭协程
        //关闭所有协程
        StopAllCoroutines();
        //关闭指定协程
        StopCoroutine(c1);
        #endregion
        #region 五 yield return 不同内容的含义
        //1.下一帧执行
        //yield return 数字;
        //yield return null;
        //在Update和LateUpdate之间执行

        //2.等待指定秒后执行
        //yield return new WaitForSeconds(秒);
        //在Update和LateUpdate之间执行

        //3.等待下一个固定物理帧更新时执行
        //yield return new WaitForFixedUpdate();
        //在FixedUpdate和碰撞检测相关函数之后执行

        //4.等待摄像机和GUI渲染完成后执行
        //yield return new WaitForEndOfFram();
        //在LateUpdate之后的渲染相关处理完毕之后

        //5.一些特殊类型的对象 比如异步加载相关函数返回的对象
        //一般在Update和LateUpdate之间执行

        //6.跳出协程
        //yield break;
        #endregion
        #region 总结
        //1.Unity支持多线程，只是新开的线程无法访问主线程中Unity相关内容
        //  一般主要用于进行复杂逻辑运算或者网络消息接收等等
        //  注意 ：Unity中的多线程一定记住要关闭
        //2.协同程序不是多线程，他是将线程中逻辑进行分时执行，避免卡顿
        //3.继承MonoBeahvior的类都可以使用协程
        //4.协程只有当组件单独失活时不受影响，其他情况都会停止
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        if(queue.Count > 0)
        {
            this.transform.position = queue.Dequeue();
        }
    }
    //关键点一： 协同程序函数 返回值 必须是IEnumerator或者继承它的类型

    IEnumerator MyCoroutine(int i ,string str)
    {
        print(i);
        //协程函数当中 必须使用 yield return 进行返回
        yield return new WaitForSeconds(5f);
        print(str);
    }

    private void Test()
    {
        while(true)
        {
            Thread.Sleep(1000);
            //相当于模拟 复杂算法 算出了一个结果 然后放到公共容器中
            System.Random r = new System.Random();  
            queue.Enqueue(new Vector3(r.Next(-10,10), r.Next(-10, 10), r.Next(-10, 10)));
            print("新开进程");
        }
        
    }

    private void OnDestroy()
    {
        t.Abort();
        t = null;
    }
}
