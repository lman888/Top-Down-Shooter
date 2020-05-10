using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Object m_bullet;
    public Object m_bulletSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootBullets();
    }

    void ShootBullets()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Left Click down");
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("Right Click down");
        }
    }
}
