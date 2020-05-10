using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    private Vector3 m_targetPos;

    private Transform m_target;
    // Start is called before the first frame update
    void Start()
    {
        m_target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollow();
    }

    void CameraFollow()
    {
        m_targetPos = new Vector3(m_target.position.x, transform.position.y, m_target.position.z);

        transform.position = Vector3.Lerp(transform.position, m_targetPos, Time.deltaTime * 8);
    }

}
