using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0,0,1);
        // transform.Translate(Vector3.up * Time.deltaTime);
        transform.Rotate(0,0,0.1f);
        transform.Translate(0, 0.01f, 0);
    }
}
