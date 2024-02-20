using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy2 : MonoBehaviour
{
    public Transform A;
    public Transform B;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Dot(A.forward, B.position-A.position) >= 0)
        {
            Vector3 cross = Vector3.Cross(A.forward, B.position-A.position);
            if(cross.y >=0)
            {
                print("B在A右上");
            }
            else
            {
                print("B在A左上");
            }
        }
        else
        {
            Vector3 cross = Vector3.Cross(A.forward, B.position-A.position);
            if (cross.y >= 0)
            {
                print("B在A右下");
            }
            else
            {
                print("B在A左下");
            }
        }

    }
}
