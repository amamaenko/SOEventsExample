using UnityEngine;
using System.Collections;

/// MouseLook rotates the transform based on the mouse delta.
/// Minimum and Maximum values can be used to constrain the possible rotation

/// To make an FPS style character:
/// - Create a capsule.
/// - Add a rigid body to the capsule
/// - Add the MouseLook script to the capsule.
///   -> Set the mouse look to use LookX. (You want to only turn character but not tilt it)
/// - Add FPSWalker script to the capsule

/// - Create a camera. Make the camera a child of the capsule. Reset it's transform.
/// - Add a MouseLook script to the camera.
///   -> Set the mouse look to use LookY. (You want the camera to tilt up and down like a head. The character already turns.)
public class MouseLook : MonoBehaviour {
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;


    void Update() {

        transform.position += (
                    transform.forward * Input.GetAxis("Vertical") + 
                    transform.right * Input.GetAxis("Horizontal")) * speed * Time.deltaTime;

        transform.Rotate(0.0f, Input.GetAxis("Mouse X") * rotationSpeed, 0.0f);
    }
}