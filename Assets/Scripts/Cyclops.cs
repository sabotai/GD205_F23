using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{
    public float boomForce = 750f;
    public float boomRad = 60f;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(laser, out hit)){
            Debug.Log("you hit " + hit.transform.name);
            if (Input.GetMouseButton(0) && hit.rigidbody){
                hit.rigidbody.AddExplosionForce(boomForce, hit.point, boomRad);
            }

            if (Input.GetMouseButtonDown(1)){
                Instantiate(prefab, hit.point, Quaternion.identity);
            }
        }
    }
}
