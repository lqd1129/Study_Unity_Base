using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_FireType
{
    One,
    Two,
    Three,
    Round
}
public class AirPlane : MonoBehaviour
{
    private E_FireType nowType;
    public GameObject bullet;
    public int roundNum = 4;
    // Start is called before the first frame update
    void Start()
    {
        nowType = E_FireType.One;
    }

    // Update is called once per frame
    void Update()
    {
        //切换开火方式
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            nowType = E_FireType.One;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            nowType = E_FireType.Two;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            nowType = E_FireType.Three;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            nowType = E_FireType.Round;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        
    }

    private void Fire()
    {
        switch (nowType)
        {
            case E_FireType.One:
                Instantiate(bullet,transform.position,transform.rotation);
                break;
            case E_FireType.Two:
                //让发射位置分别向两边的方向偏移一点
                Instantiate(bullet, transform.position - transform.right * 1, transform.rotation);
                Instantiate(bullet, transform.position + transform.right * 1, transform.rotation);
                break;
            case E_FireType.Three:
                Instantiate(bullet, transform.position, transform.rotation);
                Instantiate(bullet, transform.position - transform.right * 1, transform.rotation * Quaternion.AngleAxis(-20, Vector3.up));
                Instantiate(bullet, transform.position + transform.right * 1, transform.rotation * Quaternion.AngleAxis(20, Vector3.up));
                break;
            case E_FireType.Round:
                float angle = 360/roundNum;
                for(int i = 0; i < roundNum; i++)
                {
                    Instantiate(bullet, this.transform.position, this.transform.rotation * Quaternion.AngleAxis(i * angle, Vector3.up));
                }

                break;
        }
    }
}
