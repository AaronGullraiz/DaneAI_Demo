using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator _anim;
    public float walkSpeed = 1;
    public float rotationSpeed = 1;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var walk = Input.GetAxis("Vertical");
        controller.Move(transform.forward* walkSpeed * walk);
        _anim.SetFloat("walk", Mathf.Abs(walk));

        var rot = transform.localEulerAngles;
        rot.y += Input.GetAxis("Horizontal")* rotationSpeed;
        transform.localEulerAngles = rot;


    }
}