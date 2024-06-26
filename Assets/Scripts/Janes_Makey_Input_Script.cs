using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janes_Makey_Input_Script : MonoBehaviour
{
    public bool code0 = false; //Diesen dürfen und können wir nicht benutzten weil sonst kein Stromskreis zustande kommt.

    public bool code1 = false;
    public bool code2 = false;
    public bool code3 = false;
    public bool code4 = false;
    public bool code5 = false;
    public bool code6 = false;
    public bool code7 = false;

    public bool firstDigitis1 = false;
    public bool secondDigitis1 = false;
    public bool thirdDigitis1 = false;

    /*  
        000     0
        100     1
        110     2
        111     3           Kombinationsmöglichkeintenübersicht!
        101     4
        001     5
        010     6
        011     7
    */


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {  
             firstDigitis1 = true;
             //Debug.Log("Links/Up");
        }   

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            secondDigitis1 = true;
            //Debug.Log("Mitte/Down");
        }   

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thirdDigitis1 = true;
            //Debug.Log("Rechts/Space");   
        }



        //Hier beginnt die Abfrage und zuweisung der Kombinationen



        if (firstDigitis1 == true && secondDigitis1 == false && thirdDigitis1 == false)
        {
            Debug.Log("#1");
        }


        if (firstDigitis1 == true && secondDigitis1 == true && thirdDigitis1 == false)
        {
            Debug.Log("#2");
        }


        if (firstDigitis1 == true && secondDigitis1 == true && thirdDigitis1 == true)
        {
            Debug.Log("#3");
        }


        if (firstDigitis1 == true && secondDigitis1 == false && thirdDigitis1 == true)
        {
            Debug.Log("#4");
        }


        if (firstDigitis1 == false && secondDigitis1 == false && thirdDigitis1 == true)
        {
            Debug.Log("#5");
        }


        if (firstDigitis1 == false && secondDigitis1 == true && thirdDigitis1 == false)
        {
            Debug.Log("#6");
        }


        if (firstDigitis1 == false && secondDigitis1 == true && thirdDigitis1 == true)
        {
            Debug.Log("#7");
        }



        // Zum Schluss den Input wieder auf "000" setzen

        firstDigitis1 = false;
        secondDigitis1 = false;
        thirdDigitis1 = false;
}
}
