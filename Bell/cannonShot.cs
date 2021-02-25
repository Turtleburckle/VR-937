using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonShot : MonoBehaviour
{
    private bool canShot = false;
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canShot = true;
            audioData.Play(0);
        }
        if (canShot) { transform.position += new Vector3(Time.deltaTime * -25, 0, 0); }
    }
}
