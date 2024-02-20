using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        #region 调试画线
        //画线段
        //前两个参数分别是起点和终点
        //Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward, Color.red);

        //画射线
        //前两个参数分别是起点和方向
        //Debug.DrawRay(this.transform.position, this.transform.forward, Color.white);

        #endregion

        #region 通过点乘判断对象方位
        //Vector 提供了计算点乘的方法 Vector3.dot
        Debug.DrawRay(this.transform.position,this.transform.forward, Color.red);
        Debug.DrawRay(this.transform.position,target.position - transform.position , Color.red);

        float dotResult = Vector3.Dot(transform.position,target.position-transform.position);
        if(dotResult >= 0)
        {
            print("对方在我前方");
        }
        else
        {
            print("对方在我后方");
        }
        #endregion

        #region 通过点乘推导公式算出夹角
        //步骤
        //1.用单位向量计算出点乘结果
        dotResult = Vector3.Dot(this.transform.forward, (target.position - transform.position).normalized);
        //2.用反三角函数计算出角度
        print("角度是" +  Mathf.Acos(dotResult)*Mathf.Rad2Deg);

        //也可也直接用API
        print("角度2" + Vector3.Angle(this.transform.forward, target.position - this.transform.position));
        #endregion
    }
}
