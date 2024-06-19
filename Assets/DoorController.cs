using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door; // Die Tür, die geöffnet werden soll
    public float openAngle = 90f; // Der Winkel, um den die Tür geöffnet werden soll
    public float openSpeed = 2f; // Die Geschwindigkeit, mit der die Tür geöffnet wird
    public KeyCode openKey = KeyCode.E; // Die Taste, die zum Öffnen der Tür gedrückt werden muss

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
            isDoorOpen = !isDoorOpen; // Türstatus umschalten
        }

        // Tür öffnen oder schließen
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
