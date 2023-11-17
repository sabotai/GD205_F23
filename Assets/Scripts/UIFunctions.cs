using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    int myIntName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Dice roll = " + DiceRoll());
        Debug.Log("Rigged roll = " + RiggedDiceRoll()); 
    }

    int DiceRoll(){
        int dRoll = Random.Range(0, 6);

        return dRoll;
    }

    int RiggedDiceRoll(){
        return 6;
    }

    public void ChangeScene(){
        //add code to change scene
        SceneManager.LoadScene("Week8");
    }
}
