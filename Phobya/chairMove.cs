using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "ColumnChair")
            {
                //Then to destroy the object, as you asked below
                transform.position = new Vector3(-111f, 105f, 169f);
            }
        }
    }
}
