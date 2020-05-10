using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (CharacterController))]
public class PlayerController : MonoBehaviour
{
    //Components
    private CharacterController m_controller;

    //System
    private Quaternion m_targetRot;

    //Handling
    public Transform m_playerOBJ;

    public float m_walkSpeed = 0;

    public float m_runSpeed = 0;

    public float m_rotationSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_playerOBJ = this.transform;

        m_controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Gets the Horizontal and Vertical Axis of the player (0 for the Y axis)
        Vector3 m_input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));


        //If no keys are pressed, player will stay looking in the current direction
        if (m_input != Vector3.zero)
        {
            //Rotation we want to look at
            m_targetRot = Quaternion.LookRotation(m_input);

            //Only affecting the Y value                                //We can access the eulerAngles but cannot write to them.
            transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, m_targetRot.eulerAngles.y, m_rotationSpeed * Time.deltaTime);
        }

        Vector3 m_motion = m_input;

        m_motion *= (Input.GetButton("Run")) ? m_runSpeed : m_walkSpeed;

        m_motion += Vector3.up * -8;

        m_controller.Move(m_motion * Time.deltaTime);
    }
}
