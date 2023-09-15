using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log("W key pressed");
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.A)){
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.Q)){
            transform.position += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.E)){
            transform.position += Vector3.up;
        }
/*
        if (transform.position == hazard.transform.position){
           Debug.Log("you are hazards ): lul");
           Destroy(gameObject);
        }
*/
        //for loop ... the first part is a declaration and assignment for a variable to iterate through our loop
        //the second part is a condition .. after each run, it will check if this is true 
        //the third part will update i after each time it runs
        for (int i = 0; i < hazards.Length; i++){
           if (transform.position == hazards[i].transform.position){
           Debug.Log("you are hazards ): lul");
           Destroy(gameObject);
           }
        }
    }
}
