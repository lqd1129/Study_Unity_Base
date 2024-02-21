using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18 : MonoBehaviour
{
    private Texture tex;
    // Start is called before the first frame update
    void Start()
    {
        #region һ��Resources�첽������ʲô
        //��ͬ��������
        //������ع������Դ���ܻ���ɳ��򿨶�
        //���ٵ�ԭ����� ��Ӳ���ϰ����ݶ�ȡ���ڴ��� ����Ҫ���м���� 
        //Խ�����Դ��ʱԽ�����ͻ���ɵ�֡����

        //Resources�첽���� �����ڲ��¿�һ���߳̽�����Դ���� ����������߳̿���
        #endregion

        #region ����Resources�첽���ط���
        //ע�⣺
        //�첽���� �������ϵõ����ص���Դ ����Ҫ��һ֡

        //1.ͨ���첽�����е�����¼����� ʹ�ü��ص���Դ
        //��Unity�ڲ� ���Լ���һ���߳̽�����Դ����
        ResourceRequest rq =  Resources.LoadAsync<Texture>("TexJPG");
        rq.completed += OverLoad;

        //2.ͨ��Э�� ʹ�ü��ص���Դ 

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator loadAsset()
    {
        //���������� ������yield return ʱ �ͻ�ִֹͣ��֮��Ĵ���
        //Ȼ�� Э�̵�����ͨ���õ����ص�ֵ�ж�ʲôʱ��ִ������Ĵ���

        //��һ��
        ResourceRequest rq = Resources.LoadAsync<Texture>("TexJPG");
        //unity �Լ�֪�� �÷���ֵ ��ζ�������첽������Դ
        //����Դ�������֮��Ż�ִ�� yield return ֮��Ĵ���
        yield return rq;
        //�ڶ���
        tex =  rq.asset as Texture;


    }
    private void OverLoad(AsyncOperation rq)
    {
        print("�������");
        //asset����Դ���� ������Ϲ��� ���ܹ��õ���
        tex =  (rq as ResourceRequest).asset as Texture;
    }
    private void OnGUI()
    {
        if(tex != null)
        {
            GUI.DrawTexture(new Rect(0, 0, 0, 100), tex);
        }
    }
}
