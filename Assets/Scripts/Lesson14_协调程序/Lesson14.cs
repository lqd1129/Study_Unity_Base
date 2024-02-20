using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public Thread t;
    //����һ��������Ϊһ���������ڴ�����
    Queue<Vector3> queue = new Queue<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        #region һ Unity�Ƿ�֧�ֶ��߳�
        //����Ҫ��ȷһ��
        //Unity�Ƿ�֧�ֶ��߳�
        //ֻ���¿��߳��޷�����Unity��ض��������

        //ע�� �� Unity�еĶ��߳� Ҫ�ǵùر�
        t = new Thread(Test);
        //t.Start();

        //�ô����ڽ���һЩѰ·�㷨�����Լ�����ͨ���������ʱ�����ܻᵼ�����߳̿��٣����ʱ��ʹ�ø��߳�������
        #endregion
        #region �� Эͬ������ʲô
        //Эͬ������Э��
        //����"��"�Ķ��߳� �������Ƕ��߳�

        //��Ҫ����
        //�������ʱִ�У��������߳�
        //����⣬�ǰɿ��ܻ������߳̿��ٵĺ�ʱ�߼���ʱ�ֲ�ִ��

        //��Ҫʹ�õĳ�����
        //�첽�����ļ�
        //�첽�����ļ�
        //�����첽����
        //��������ʱ��ֹ����
        #endregion
        #region �� Эͬ������̵߳�����
        //�¿�һ���߳��Ƕ�����һ���ܵ��������̲߳���ִ��
        //�¿�һ��Э������ԭ�߳�֮�Ͽ����������߼���ʱ�ֲ�ִ��
        #endregion
        #region �� Э�̵�ʹ��
        //�̳�MonoBehavior���� �����Կ��� Э�̺���
        //��һ��������Э�̺���
        // Э�̺���2���ؼ���
        // 1-1 ����ֵΪIEnumerator���ͼ�������
        // 1-2������ͨ�� yield return ����ֵ�������з���

        //�ڶ���������Э�̺���
        //Э�̺�������ֱ��ȥִ��
        //MyCoroutine(1, "123");
        //���ÿ�����ʽ
        Coroutine  c1 = StartCoroutine(MyCoroutine(1, "123"));
        Coroutine  c2 = StartCoroutine(MyCoroutine(1, "123"));
        Coroutine  c3 = StartCoroutine(MyCoroutine(1, "123"));

        //���������ر�Э��
        //�ر�����Э��
        StopAllCoroutines();
        //�ر�ָ��Э��
        StopCoroutine(c1);
        #endregion
        #region �� yield return ��ͬ���ݵĺ���
        //1.��һִ֡��
        //yield return ����;
        //yield return null;
        //��Update��LateUpdate֮��ִ��

        //2.�ȴ�ָ�����ִ��
        //yield return new WaitForSeconds(��);
        //��Update��LateUpdate֮��ִ��

        //3.�ȴ���һ���̶�����֡����ʱִ��
        //yield return new WaitForFixedUpdate();
        //��FixedUpdate����ײ�����غ���֮��ִ��

        //4.�ȴ��������GUI��Ⱦ��ɺ�ִ��
        //yield return new WaitForEndOfFram();
        //��LateUpdate֮�����Ⱦ��ش������֮��

        //5.һЩ�������͵Ķ��� �����첽������غ������صĶ���
        //һ����Update��LateUpdate֮��ִ��

        //6.����Э��
        //yield break;
        #endregion
        #region �ܽ�
        //1.Unity֧�ֶ��̣߳�ֻ���¿����߳��޷��������߳���Unity�������
        //  һ����Ҫ���ڽ��и����߼��������������Ϣ���յȵ�
        //  ע�� ��Unity�еĶ��߳�һ����סҪ�ر�
        //2.Эͬ�����Ƕ��̣߳����ǽ��߳����߼����з�ʱִ�У����⿨��
        //3.�̳�MonoBeahvior���඼����ʹ��Э��
        //4.Э��ֻ�е��������ʧ��ʱ����Ӱ�죬�����������ֹͣ
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        if(queue.Count > 0)
        {
            this.transform.position = queue.Dequeue();
        }
    }
    //�ؼ���һ�� Эͬ������ ����ֵ ������IEnumerator���߼̳���������

    IEnumerator MyCoroutine(int i ,string str)
    {
        print(i);
        //Э�̺������� ����ʹ�� yield return ���з���
        yield return new WaitForSeconds(5f);
        print(str);
    }

    private void Test()
    {
        while(true)
        {
            Thread.Sleep(1000);
            //�൱��ģ�� �����㷨 �����һ����� Ȼ��ŵ�����������
            System.Random r = new System.Random();  
            queue.Enqueue(new Vector3(r.Next(-10,10), r.Next(-10, 10), r.Next(-10, 10)));
            print("�¿�����");
        }
        
    }

    private void OnDestroy()
    {
        t.Abort();
        t = null;
    }
}
