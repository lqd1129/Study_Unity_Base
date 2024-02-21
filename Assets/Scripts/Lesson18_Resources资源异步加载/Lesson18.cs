using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18 : MonoBehaviour
{
    private Texture tex;
    // Start is called before the first frame update
    void Start()
    {
        #region 一、Resources异步加载是什么
        //在同步加载中
        //如果加载过大的资源可能会造成程序卡顿
        //卡顿的原因就是 从硬盘上把数据读取到内存中 是需要进行计算的 
        //越大的资源耗时越长，就会造成掉帧卡顿

        //Resources异步加载 就是内部新开一个线程进行资源加载 不会造成主线程卡顿
        #endregion

        #region 二、Resources异步加载方法
        //注意：
        //异步加载 不能马上得到加载的资源 至少要等一帧

        //1.通过异步加载中的完成事件监听 使用加载的资源
        //在Unity内部 会自己开一个线程进行资源下载
        ResourceRequest rq =  Resources.LoadAsync<Texture>("TexJPG");
        rq.completed += OverLoad;

        //2.通过协程 使用加载的资源 

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator loadAsset()
    {
        //迭代器函数 当遇到yield return 时 就会停止执行之后的代码
        //然后 协程调度器通过得到返回的值判断什么时候执行下面的代码

        //第一步
        ResourceRequest rq = Resources.LoadAsync<Texture>("TexJPG");
        //unity 自己知道 该返回值 意味着你在异步加载资源
        //当资源加载完毕之后才会执行 yield return 之后的代码
        yield return rq;
        //第二步
        tex =  rq.asset as Texture;


    }
    private void OverLoad(AsyncOperation rq)
    {
        print("加载完成");
        //asset是资源对象 加载完毕过后 就能够得到它
        tex =  (rq as ResourceRequest).asset as Texture;
    }
    private void OnGUI()
    {
        if(tex != null)
        {
            GUI.DrawTexture(new Rect(0, 0, 0, 100), tex);
        }
    }
}
