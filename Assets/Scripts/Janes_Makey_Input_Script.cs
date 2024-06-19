using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janes_Makey_Input_Script : MonoBehaviour
{
    public bool code0 = false; //Disen dürfen und können wir nicht benutzten weil sonst kein Stromskreis zustande kommt.

    public bool code1 = false;
    public bool code2 = false;
    public bool code3 = false;
    public bool code4 = false;
    public bool code5 = false;
    public bool code6 = false;
    public bool code7 = false;


    /*  
        000     0
        100     1
        110     2
        111     3
        101     4
        001     5
        010     6
        011     7
    */


    void Update()
    {
        // 100
        if (Input.GetKeyDown(KeyCode.UpArrow)) & !(Input.GetKeyDown(KeyCode.DownArrow)) & !(Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.Log("Up Arrow Pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Debug.Log("Down Arrow Pressed");
        }   

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.Log("Space Key Pressed");   
        }
    }
}
