using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementJS : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Camera camera;
    [SerializeField] float speed = 3;

    void Update (){

        Vector3 velocity = camera.transform.forward * Input.GetAxis("Vertical") * speed;
        transform.position += velocity * Time.deltaTime;
    }
}
