using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region һ��Resources��Դ��̬���ص�����
        //ͨ�����붯̬����Resources�ļ����е���Դ
        //����Ƶ������ק����
        #endregion

        #region ����������Դ����
        //1.Ԥ�������� - GameObject
        //2.��Ƶ�ļ� - AudioClip
        //3.�ı��ļ� - TextAsset
        //4.ͼƬ�ļ� - Texture
        //5.��������-- ��Ҫʲô��ʲô����

        //ע�⣺
        //Ԥ������������Ҫʵ����
        //������Դ����һ��ֱ����

        #endregion

        #region ������Դͬ������ ��ͨ����
        //��һ�����̵��� Resources�ļ��п����ж�� ͨ��API����ʱ  �����Լ�ȥ��Щͬ����Resources�ļ������Ҷ�Ӧ����Դ
        //���ʱ Resources�ļ������������ ��������һ�� �Զ�����

        //1.Ԥ������� ��Ҫ����զ������ Ҫʵ����
        //��һ��������Ԥ�������Դ�ļ�
        Object obj = Resources.Load("Cube");
        //�ڶ��� ʵ����
        Instantiate(obj);

        //���⣺��Դͬ����ô��
        //����ʹ�������API
        //����ָ�����͵���Դ
        Texture tex = Resources.Load("tupian", typeof(Texture)) as Texture;

        //����ָ�����ֵ�������Դ
        Object[]  objs = Resources.LoadAll("tupian");
        foreach (var item in objs)
        {
            if(item is Texture)
            {

            }
            if(item is TextAsset)
            {

            }
        }
        #endregion


        #region �ġ���Դͬ������ ���ͷ���
        TextAsset tex2 = Resources.Load<TextAsset>("Tex2");
        #endregion

        #region �ܽ�
        //Resources��̬������Դ�ķ���
        //����չ�Ը�ǿ

        //�����ק��˵ ������һ������ ���ӷ���

        //��Ҫ�ĵ㣺

        //��סAPI

        //Resources.Load

        //Resources.LoadAll

        //Resources.Load<T>
        //��Ҫ��סһЩ�ض��ĸ�ʽ

        //Ԥ������س���һ��Ҫʵ����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
