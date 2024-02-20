using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ����
        //��ά���� - Vector3
        //Vector3�����ּ�������
        //1.λ�� -- ����һ����
        print(this.transform.position);

        //2.���� -- ����һ������
        print(this.transform.forward);
        print(this.transform.up);
        #endregion

        #region �������һ����
        //A��B��ʱ �������� ��������
        Vector3 A = new Vector3(1, 2, 3);
        Vector3 B = new Vector3(4, 5, 6);
        //������
        //��ʱ AB�� BA ���ǵļ������� ����������
        Vector3 AB = B - A;
        Vector3 BA = A - B;
        //���������������������������������Transform.position���
        #endregion

        #region �������͸�����
        //������
        print(Vector3.zero);

        print(Vector3.forward);
        //������
        print(-Vector3.up);
        #endregion

        #region ������ģ��
        //Vector3���ṩ�˻�ȡ����ģ���ĳ�Ա���� 
        //magnitude
        print(AB.magnitude);
        Vector3 C = new Vector3(1, 2, 3);
        print(C.magnitude);

        //��������Ǽ���������֮��ľ��룬�����ģ��һ��
        //Vector3.Distance(A, B);
        #endregion

        #region ��λ����
        //Vector3���ṩ�˻�ȡ��λ�����ĳ�Ա����
        //normallized
        print(AB.normalized);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
