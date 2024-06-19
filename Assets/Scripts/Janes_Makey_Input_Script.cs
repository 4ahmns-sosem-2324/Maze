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
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            Debug.Log("Links");
        }   

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Debug.Log("Mitte");
        }   

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.Log("Rechts");   
        }
    }
}
