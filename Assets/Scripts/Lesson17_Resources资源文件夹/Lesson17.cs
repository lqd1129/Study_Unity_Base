using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 一、Resources资源动态加载的作用
        //通过代码动态加载Resources文件夹中的资源
        //避免频繁的拖拽操作
        #endregion

        #region 二、常用资源类型
        //1.预设体类型 - GameObject
        //2.音频文件 - AudioClip
        //3.文本文件 - TextAsset
        //4.图片文件 - Texture
        //5.其他类型-- 需要什么用什么类型

        //注意：
        //预设体对象加载需要实例化
        //其他资源加载一般直接用

        #endregion

        #region 三、资源同步加载 普通方法
        //在一个工程当中 Resources文件夹可以有多个 通过API加载时  它会自己去这些同名的Resources文件夹中找对应的资源
        //打包时 Resources文件夹里面的内容 都会打包在一起 自动整合

        //1.预设体对象 想要创建咋场景上 要实例化
        //第一步：加载预设体的资源文件
        Object obj = Resources.Load("Cube");
        //第二步 实例化
        Instantiate(obj);

        //问题：资源同名怎么办
        //可以使用另外的API
        //加载指定类型的资源
        Texture tex = Resources.Load("tupian", typeof(Texture)) as Texture;

        //加载指定名字的所有资源
        Object[]  objs = Resources.LoadAll("tupian");
        foreach (var item in objs)
        {
            if(item is Texture)
            {

            }
            if(item is TextAsset)
            {

            }
        }
        #endregion


        #region 四、资源同步加载 泛型方法
        TextAsset tex2 = Resources.Load<TextAsset>("Tex2");
        #endregion

        #region 总结
        //Resources动态加载资源的方法
        //让拓展性更强

        //相对拖拽来说 它更加一劳永逸 更加方便

        //重要的点：

        //记住API

        //Resources.Load

        //Resources.LoadAll

        //Resources.Load<T>
        //还要记住一些特定的格式

        //预制体加载出来一定要实例化
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
