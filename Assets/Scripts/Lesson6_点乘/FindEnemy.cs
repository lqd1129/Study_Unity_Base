using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    public Transform B;
    private float dotResult;
    

    // Update is called once per frame
    void Update()
    {
        FindEnemys();
    }

    private void FindEnemys()
    {
        //if((this.transform.position - B.position).magnitude <= 5 )
        //{
        //    //�����˽��
        //    dotResult = Vector3.Dot(this.transform.forward, (B.transform.position - this.transform.position).normalized);
        //    //�÷����Һ�������н�
        //    if (Mathf.Acos(dotResult) * Mathf.Rad2Deg <= 22.5)
        //    {
        //        print("����������");
        //    }
        //}

        //һ����λ
        if(Vector3.Angle(transform.forward, B.position-transform.position) <= 22.5f && (this.transform.position - B.position).magnitude <= 5)
        {
            print("����������"); 
        }
    }
}
