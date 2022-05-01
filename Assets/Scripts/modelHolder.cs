using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelHolder : MonoBehaviour
{
    private float speed = 15;

    private void Update() {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + Time.deltaTime * speed);
    }
}
