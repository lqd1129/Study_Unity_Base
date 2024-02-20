using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 四元数相乘
        Quaternion q = Quaternion.AngleAxis(20, Vector3.up);
        this.transform.rotation *= q;
        #endregion
        #region 四元数乘向量
        Vector3 v = Vector3.forward;
        print(v);
        //四元数乘向量的顺序不能改变，也就是说不能用向量去乘四元数，只能是四元数乘向量
        v = Quaternion.AngleAxis(45,Vector3.up) * v;
        print(v);
        v = Quaternion.AngleAxis(45, Vector3.up) * v;
        print(v);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
