using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ����·����ȡ
        //ע�⣺�÷�ʽһ���ڱ༭ģʽ��ʹ��
        //������ʵ�ʷ�����Ʒ�� ��ʹ�ø�·��
        //���������·���Ͳ�������
        print(Application.dataPath);
        #endregion

        #region Resources ��Դ�ļ���
        //·����ȡ
        //һ�㲻��ȡ
        //ֻ��ʹ��Resource���API���м���
        //���ӲҪ��ȡ �����ù���·��ƴ��
        print(Application.dataPath + "/Resources");

        //ע�⣺
        //���ļ�����Ҫ�����Լ�����
        //���ã�
        //��Դ�ļ���
        //1-1.��Ҫͨ�����API��̬���ص���Դ��Ҫ��������
        //1-2.���ļ����������ļ����ᱻ�����ȥ
        //1-3.���ʱunity�����ѹ������
        //1-4.���ļ��д����ֻ�� ֻ��ͨ�����API����
        #endregion

        #region StreamingAssets ������Դ�ļ���
        //·����ȡ��
        print(Application.streamingAssetsPath);
        //ע�⣺
        //��Ҫ�����Լ�ȥ�������ļ���
        //���ã�
        //���ļ���
        //2-1.�����ȥ���ᱻѹ�����ܣ���������ڲ�
        //2-2.�ƶ�ƽֻ̨����PCƽ̨�ɶ���д
        //2-3.���Է���һЩ��Ҫ�Զ��嶯̬���صĳ�ʼ��Դ
        #endregion

        #region persistentDataPath �־������ļ���
        //·����ȡ��
        print(Application.persistentDataPath);
        //ע�⣺
        //����Ҫ�����Լ�ȥ�������ļ���
        //���ã�
        //�̶������ļ���
        //3-1.����ƽ̨���ɶ���д
        //3-2.һ�����ڷ�ֹ��̬���ػ��߶�̬�������ļ�����Ϸ�д������߻�ȡ���ļ�����������
        #endregion

        #region  Pluins ����ļ���
        //·����ȡ��
        //һ�㲻��ȡ
        //ע�⣺
        //��Ҫ�����Լ�ȥ�������ļ���
        //���ã�
        //����ļ���
        //��ͬƽ̨�Ĳ������ļ���������
        //����IOS��Androidƽ̨
        #endregion
        #region  Editor �༭���ļ���
        //·����ȡ��
        //һ�㲻��ȡ

        //ע�⣺
        //��Ҫ�����Լ�ȥ�������ļ���
        //���ã�
        //�༭���ļ���
        //5-1.����Unity�༭��ʱ���༭����ؽű����ڸ��ļ�����
        //5-2.���ļ��������ݲ��ᱻ�����ȥ
        #endregion

        #region  Ĭ����Դ�ļ��� Standard Assets
        //·����ȡ��
        //һ�㲻��ȡ

        //ע�⣺
        //��Ҫ�����Լ�ȥ�������ļ���
        //���ã�
        //Ĭ����Դ�ļ���
        //6-1.һ��Unity�Դ�����Դ��������ļ�����
        //5-2.�������Դ���ȱ�����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
