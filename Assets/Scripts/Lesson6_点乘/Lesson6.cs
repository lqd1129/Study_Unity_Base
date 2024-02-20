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
        #region ���Ի���
        //���߶�
        //ǰ���������ֱ��������յ�
        //Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward, Color.red);

        //������
        //ǰ���������ֱ������ͷ���
        //Debug.DrawRay(this.transform.position, this.transform.forward, Color.white);

        #endregion

        #region ͨ������ж϶���λ
        //Vector �ṩ�˼����˵ķ��� Vector3.dot
        Debug.DrawRay(this.transform.position,this.transform.forward, Color.red);
        Debug.DrawRay(this.transform.position,target.position - transform.position , Color.red);

        float dotResult = Vector3.Dot(transform.position,target.position-transform.position);
        if(dotResult >= 0)
        {
            print("�Է�����ǰ��");
        }
        else
        {
            print("�Է����Һ�");
        }
        #endregion

        #region ͨ������Ƶ���ʽ����н�
        //����
        //1.�õ�λ�����������˽��
        dotResult = Vector3.Dot(this.transform.forward, (target.position - transform.position).normalized);
        //2.�÷����Ǻ���������Ƕ�
        print("�Ƕ���" +  Mathf.Acos(dotResult)*Mathf.Rad2Deg);

        //Ҳ��Ҳֱ����API
        print("�Ƕ�2" + Vector3.Angle(this.transform.forward, target.position - this.transform.position));
        #endregion
    }
}
