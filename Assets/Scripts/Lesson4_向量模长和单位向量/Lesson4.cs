using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 向量
        //三维向量 - Vector3
        //Vector3有两种几何意义
        //1.位置 -- 代表一个点
        print(this.transform.position);

        //2.方向 -- 代表一个方向
        print(this.transform.forward);
        print(this.transform.up);
        #endregion

        #region 两点决定一向量
        //A和B此时 几何意义 是两个点
        Vector3 A = new Vector3(1, 2, 3);
        Vector3 B = new Vector3(4, 5, 6);
        //求向量
        //此时 AB和 BA 他们的几何意义 是两个向量
        Vector3 AB = B - A;
        Vector3 BA = A - B;
        //如果想求两个物体的向量就用两个物体的Transform.position相减
        #endregion

        #region 零向量和负向量
        //零向量
        print(Vector3.zero);

        print(Vector3.forward);
        //负向量
        print(-Vector3.up);
        #endregion

        #region 向量的模长
        //Vector3中提供了获取向量模长的成员属性 
        //magnitude
        print(AB.magnitude);
        Vector3 C = new Vector3(1, 2, 3);
        print(C.magnitude);

        //这个方法是计算两个点之间的距离，结果和模长一样
        //Vector3.Distance(A, B);
        #endregion

        #region 单位向量
        //Vector3中提供了获取单位向量的成员属性
        //normallized
        print(AB.normalized);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
