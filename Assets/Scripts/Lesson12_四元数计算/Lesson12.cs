using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ��Ԫ�����
        Quaternion q = Quaternion.AngleAxis(20, Vector3.up);
        this.transform.rotation *= q;
        #endregion
        #region ��Ԫ��������
        Vector3 v = Vector3.forward;
        print(v);
        //��Ԫ����������˳���ܸı䣬Ҳ����˵����������ȥ����Ԫ����ֻ������Ԫ��������
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
