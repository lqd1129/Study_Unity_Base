using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{

    public Transform targetObj;
    public float moveSpeed;
    private Vector3 targetPos;
    private Vector3 startPos;
    
    public float time;


    // Update is called once per frame
    void LateUpdate()
    {
        if(targetPos != targetObj.position + -targetObj.forward * 4 + targetObj.up * 7)
        {
            targetPos = targetObj.position + -targetObj.forward * 4 + targetObj.up * 7;
            startPos = this.transform.position;
            time = 0;
        }
        //ÏÈ¿éºóÂý
        //this.transform.position = Vector3.Lerp(this.transform.position, targetPos, Time.deltaTime*moveSpeed);
        //this.transform.LookAt(targetObj);

        //ÔÈËÙ
        this.transform.position = Vector3.Lerp(startPos, targetPos, time * moveSpeed);
        time += Time.deltaTime;
        this.transform.LookAt(targetObj);
    }
}
