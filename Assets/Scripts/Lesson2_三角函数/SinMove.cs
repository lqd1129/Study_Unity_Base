using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour
{
    //�泯���ٶ�
    public float moveSpeed = 5;
    //���������ƶ��仯���ٶ�
    public float changeSpeed = 2;
    //���������ƶ��������
    public float changeSize = 0.5f;

    private float time = 0;
    

    // Update is called once per frame
    void Update()
    {
        //�泯���ƶ�
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        //���������ƶ�
        time += Time.deltaTime * changeSpeed;
        this.transform.Translate(Vector3.right * Time.deltaTime * changeSize * Mathf.Sin(time)); 
    }
}
