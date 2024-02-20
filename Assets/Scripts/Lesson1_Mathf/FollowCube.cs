using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    public Transform followObj;
    public float moveSpeed;
    private Vector3 pos;
    private Vector3 followObjNowPos;
    private float time;
    private Vector3 startPos;
  
    // Update is called once per frame
    void Update()
    {
        //第一种 就是先快 后慢的形式
        //pos = this.transform.position;

        //pos.x = Mathf.Lerp(pos.x , followObj.transform.position.x,Time.deltaTime*moveSpeed);  
        //pos.y = Mathf.Lerp(pos.y , followObj.transform.position.y,Time.deltaTime*moveSpeed);  
        //pos.z = Mathf.Lerp(pos.z , followObj.transform.position.z,Time.deltaTime*moveSpeed);  

        //this.transform.position = pos;

        //第二种 匀速靠近
        
        if(followObjNowPos != followObj.transform.position)
        {
            time = 0;
            followObjNowPos = followObj.transform.position;
            startPos = this.transform.position;
        }

        time += Time.deltaTime;
        pos.x = Mathf.Lerp(startPos.x, followObjNowPos.x, time);
        pos.y = Mathf.Lerp(startPos.y, followObjNowPos.y, time);
        pos.z = Mathf.Lerp(startPos.z, followObjNowPos.z, time);

        this.transform.position = pos;  
        
    }
}
