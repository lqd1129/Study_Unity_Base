using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region һ ʲô���ӳٺ���
        // �ӳٺ�������˼����ǻ��ӳ�ִ�еĺ��������ǿ����Լ��趨��ʱҪִ�еĺ����;�����ʱ��ʱ�䡣��MonoBehaviour������ʵ�ֵĺ÷���
        #endregion
        #region �� �ӳٺ�����ʹ��
        //1.�ӳٺ���
        //Invoke
        //����һ�������� �ַ���
        //���������ӳ�ʱ�� ��Ϊ��λ
        Invoke("Test", 5);
        //ע�⣺
        //1-1.��ʱ������һ������������Ǻ��������ַ���
        //1-2.��ʱ����û�취������� ֻ�а���һ��
        //1-3.�����������Ǹýű��������ĺ���

        //2.�ӳ��ظ�ִ�к���
        //InvokeRepeating
        //����һ�����������ַ���
        //����������һ��ִ�е��ӳ�ʱ��
        //��������֮��ÿ��ִ�еļ��ʱ��
        InvokeRepeating("ReTest", 2, 1);

        //ע��������ӳٺ�����ͬ

        //3.ȡ���ӳٺ���
        //3-1ȡ���ýű��������ӳٺ�����ִ��
        //CancelInvoke();

        //3-2 ȡ��ָ���ӳٺ�����ִ��

        //CancelInvoke("ReTest");
        //ͬһ���������ܿ������ٸ��ӳ٣����ᱻȡ��ָ���ӳٺ���ȫ��ȡ��ִ��

        //4.�ж��Ƿ����ӳٺ���
        if (IsInvoking())
        {
            print("�����ӳٺ���");
        }
        else if (IsInvoking("ReTest"))
        {
            print("����ReTest�ӳٺ���");
        }

        #endregion

        #region �ӳٺ����ܶ���ʧ�����ٵ�Ӱ��
        //�ű���������ʧ�� ���߽ű��Լ�ʧ��
        //�ӳٺ������Լ���ִ��

        //�ű������������� ���߽ű����Ƴ�
        //�ӳٺ����޷�����ִ��
        #endregion

        #region �ܽ�
        //�̳�MonoBehavior�Ľű�����ʹ���ӳ���غ���
        //�������
        //Invoke ��ʱ����
        //InvokeRepeatinng �ӳ��ظ�����
        //CancelInvoke ֹͣ���л���ֹͣ�����ָ����ʱ����
        //IsInvoke �ж��Ƿ����ӳٺ�����ִ��
        //ʹ�����
        //1.�������Ǻ��������޷���������Ҫ�Ĳ���
        //2.ֻ��ִ�иýű��������ĺ���
        //3.�����ű�ʧ���޷�ֹͣ��ʱ����ִ�У�ֻ������������߶���Ż�ֹͣ���ߴ���ֹͣ

        #endregion
    }
    private void Test()
    {
        print("�ӳ�ִ��");
    }

    private void ReTest()
    {
        print("�ӳ��ظ�ִ��");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
