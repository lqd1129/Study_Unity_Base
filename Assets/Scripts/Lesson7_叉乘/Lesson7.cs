using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Transform A;
    public Transform B; 
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ��˼���
        Vector3.Cross(A.position, B.position);
        #endregion

        #region ֪ʶ��� ��˵ļ�������
        //��������A��B ����XZƽ����
        //����A�������B
        //y����0 ֤�� B��A�Ҳ�
        //yС��0 ֤�� B��A���
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 C = Vector3.Cross(A.position, B.position);
        if(C.y > 0)
        {
            print("B��A�Ҳ�");
        }
        else
        {
            print("B��A���");
        }
    }
}
