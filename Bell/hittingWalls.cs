using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittingWalls : MonoBehaviour
{
    public AudioSource bell;
    // Start is called before the first frame update
    void Start()
    {
        bell = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "Lareral1")
        {
            bell.Play();
        }
        if (collider.gameObject.name == "Lateral2") { bell.Play(); }
        if (collider.gameObject.name == "Lateral3") { bell.Play(); }
        if (collider.gameObject.name == "Lateral4") { bell.Play(); }
    }

}
