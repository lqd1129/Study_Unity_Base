using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Mathf��Math
        //Math��C#�з�װ�õ�������ѧ����Ĺ����� ����λ��Ststem�����ռ���
        //Mathf��Unity�з�װ�õ�������ѧ����Ĺ��߽ṹ�� ���� λ��UnityEngine�����ռ���
        //���Ƕ����ṩ���ڽ�����ѧ��ؼ���� 
        #endregion

        #region ֪ʶ��� ���ǵ�����
        //Mathf �� Math�е���ط�������һ��
        //Math ��C#�Դ��Ĺ����� ��Ҫ�ṩһЩ��ѧ��ؼ��㷽��
        //Mathf ��Unityר�ŷ�װ�ģ� ��������Math�еķ�����������һЩ��������Ϸ�����ķ���
        //���������ڽ���Unity����ʱ
        //ʹ��Mathf����������ѧ���㼴��
        #endregion

        #region ֪ʶ���� Mathf�г��õķ�������һ�����һ��
        //1.�� - PI
        print(Mathf.PI);

        //2.ȡ����ֵ - Abs
        print(Mathf.Abs(-10));

        //3.����ȡ�� - CeilToInt
        float f = 0.5f;
        int i = (int)f; //����ֻ������ȡ��
        print(Mathf.CeilToInt(1.3f));

        //4.����ȡ�� - FloorToInt
        print(Mathf.FloorToInt(i));

        //5.ǯ�ƺ��� - Clamp
        print(Mathf.Clamp(10,11,20));//�������С�Ļ�ҪС����ȡ��Сֵ
        print(Mathf.Clamp(21,11,20));//��������Ļ�Ҫ��ȡ���ֵ
        print(Mathf.Clamp(15,11,20));//��������ֵ����Сֵ֮�䣬ȡ�Լ�����

        //6.��ȡ���ֵ - Max
        int[] arys = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        print("����ֵ�ǣ�" + Mathf.Max(arys));

        //7.��ȡ��Сֵ - Min
        print(Mathf.Min(arys));

        //8.һ������n���� - Pow
        print("һ������N�η�:" + Mathf.Pow(4,2));
        print("һ������N�η�:" + Mathf.Pow(2,3));

        //9.�������� - RoundToInt
        print(Mathf.RoundToInt(1.6f));
        print(Mathf.RoundToInt(1.3f));


        //10.����һ������ƽ���� - Sqrt
        print(Mathf.Sqrt(4));
        print(Mathf.Sqrt(8));


        //11.�ж�һ�����Ƿ���2��n�η� - IsPowerOfTwo
        print(Mathf.IsPowerOfTwo(5));
        print(Mathf.IsPowerOfTwo(8));

        
        //12.�ж������� - Sign

        print(Mathf.Sign(4));//��������1 ��������-1 0������

        #endregion
    }
    float start = 0;
    float result = 0;
    float time = 0;
    // Update is called once per frame
    void Update()
    {

        #region ֪ʶ���� Mathf�еĳ��÷�������һ�㲻ͣ����
        //��ֵ���� - Lerp
        //Lerp������ʽ��result = Mathf.Lerp(start , end , t);

        start = Mathf.Lerp(start, 10, Time.deltaTime);

        //tΪ��ֵϵ���� ȡֵ��ΧΪ0-1 
        //result = start + ��end - start��* t

        //��ֵ�����÷�һ 
        //ÿ֡�ı� start ��ֵ�����仯�ٶ��ȿ���� �� λ�����޽ӽ� �� ���ǲ���õ� end λ��

        //��ֵ�����÷���
        //ÿ֡�ı�t��ֵ�����仯�ٶ����٣� λ��ÿ֡�ӽ� ��t >= 1 ʱ ���õ����
        time += Time.deltaTime;
        result = Mathf.Lerp(start, 10, time);


        #endregion
    }
}
