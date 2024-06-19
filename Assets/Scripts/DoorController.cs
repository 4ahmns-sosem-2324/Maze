using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door; // Die T�r, die ge�ffnet werden soll
    public float openAngle = 90f; // Der Winkel, um den die T�r ge�ffnet werden soll
    public float openSpeed = 2f; // Die Geschwindigkeit, mit der die T�r ge�ffnet wird
    public KeyCode openKey = KeyCode.E; // Die Taste, die zum �ffnen der T�r gedr�ckt werden muss

    private bool isPlayerNearby = false;
    private bool isDoorOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        // Initiale Rotationen speichern
        closedRotation = door.rotation;
        openRotation = Quaternion.Euler(door.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(openKey))
        {
            isDoorOpen = !isDoorOpen; // T�rstatus umschalten
        }

        // T�r �ffnen oder schlie�en
        if (isDoorOpen)
        {
            door.rotation = Quaternion.Slerp(door.rotation, openRotation, Time.deltaTime * openSpeed);
        }
        else
        {
            door.rotation = Quaternion.Slerp(door.rotation, closedRotation, Time.deltaTime * openSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
        }
    }
}
