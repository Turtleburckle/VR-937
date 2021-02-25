using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbage : MonoBehaviour
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
            if (hit.collider.gameObject.name == "ColumnLeft")
            {
                //Then to destroy the object, as you asked below
                Destroy(GameObject.Find("Garbage_Pile"));
            }
            }
        }
}
