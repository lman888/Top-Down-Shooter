using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform m_spawn;

    public float m_shootDistance = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShootBullets()
    {
        Ray m_ray = new Ray(m_spawn.position, m_spawn.forward);

        RaycastHit m_hit;

        //Shoots out a Ray and informs us of what we hit
        if (Physics.Raycast(m_ray, out m_hit))
        {
            m_shootDistance = m_hit.distance;
        }

        Debug.DrawRay(m_ray.origin, m_ray.direction * m_shootDistance, Color.blue);

    }
}
