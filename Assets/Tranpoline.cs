using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tranpoline : MonoBehaviour
{
    [SerializeField] private float pushForce;
    bool isInside = false;
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate() {
        if (!isInside) {
            return;
        }
        //pushPlayer();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isInside = true;
            print("Pushing");
            rb = other.GetComponent<Rigidbody>();
            //rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * pushForce, ForceMode.Force);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            isInside = false;
        }
    }

    void pushPlayer() {
        rb.AddForce(Vector3.up * pushForce, ForceMode.Force);
        print("Pushing");
    }
}
