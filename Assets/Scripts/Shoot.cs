using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float initialVelocity = 5.0f;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            var obj = Instantiate(projectilePrefab, transform.position+Vector3.up * 3, transform.rotation);
            var rigid = obj.GetComponent<Rigidbody>();
            rigid.velocity = transform.forward * initialVelocity;
        }
    }
}
