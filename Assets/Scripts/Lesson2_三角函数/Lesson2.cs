using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ���ȡ��ǶȻ���ת��
        //����ת�Ƕ�
        float rad = 1;
        float anger = rad * Mathf.Rad2Deg;

        //�Ƕ�ת����
        anger = 1;
        rad = anger * Mathf.Deg2Rad;

        #endregion

        #region ֪ʶ��� ���Ǻ���
        //ע��: Mathf�е����Ǻ�����غ���������Ĳ�����Ҫ�ǻ���ֵ
        print(Mathf.Sin(30 * Mathf.Deg2Rad));
        print(Mathf.Cos(30 * Mathf.Deg2Rad));
        print(Mathf.Cos(60 * Mathf.Deg2Rad));

        #endregion

        #region ֪ʶ���� �����Ǻ���
        //���� ͨ�������Ǻ����������һ�����ֵ��Ӧ�Ļ���ֵ
        //ע�� �� �����Ǻ����õ��Ľ���� ���һ�����ֵ��Ӧ�Ļ���
        rad = Mathf.Asin(0.5f);
        print(rad * Mathf.Rad2Deg);
        rad = Mathf.Acos(0.5f);
        print(rad * Mathf.Rad2Deg);



        #endregion
    }

    
}
