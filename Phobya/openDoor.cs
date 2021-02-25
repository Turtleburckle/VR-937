using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    // Door Related Stuff
    public GameObject Door;
    public bool doorOpen = false;
    public float currentDoorValue = 0;
    private Quaternion DoorOpen;
    // Camera related Stuff
    private Camera mainCamera;
    private float cameraMovementMaxZ = -250.0f;
    private float cameraAxisZ = -381.2f;

    public AudioSource scream;
    private bool screamed = false;
    // Start is called before the first frame update
    void Start()
    {
        Door = GameObject.Find("door");
        mainCamera = Camera.main;
        scream = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {    
        if (Input.GetKeyDown("space")) { doorOpen = true; }
        if (doorOpen && (currentDoorValue < 120) ) { 
            Door.transform.rotation = Quaternion.Euler(-89.98f, currentDoorValue, 0);
            currentDoorValue += Time.deltaTime * 20;
        }
        if (cameraAxisZ > cameraMovementMaxZ && screamed == false) { screamed = true; scream.Play(); }
        if(doorOpen&& (cameraAxisZ < cameraMovementMaxZ)) {
            mainCamera.transform.position = new Vector3(0, 90.7f, (cameraAxisZ +0.2f));
            cameraAxisZ += 0.2f  ; 
        }
    }
}
