using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 300.0f;
    static float standardSpeed = 20.0f;
    [SerializeField] float slowSpeed = 10.0f;
    [SerializeField] float boostSpeed = 10.0f;

    float moveSpeed = standardSpeed;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bump") {
            moveSpeed = slowSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            moveSpeed += boostSpeed;
            Destroy(other.gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
