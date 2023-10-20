using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStuff : MonoBehaviour
{
    CharacterController controller;
    Animator anim;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Debug.Log(move);
        anim.SetFloat("Movement", move.z);
        controller.Move(move * speed * Time.deltaTime);
/*
        if (move.z > 0f){
            anim.SetInteger("Movement", 1);
        }
        */
   }
}
