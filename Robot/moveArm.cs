using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArm : MonoBehaviour
{
    private float v = 30.0f;
    private const float lowerLimit = -30.0f;
    private const float upperLimit = 30.0f;
    private float angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((angle < lowerLimit && v < 0) || (angle > upperLimit && v > 0))
        {
            v *= -1;
        }
        float dt = Time.deltaTime;
        float dangle = v * dt;
        angle += dangle;
        transform.Rotate(Vector2.right, dangle);
    }
}
