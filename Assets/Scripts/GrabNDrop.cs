using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabNDrop : MonoBehaviour
{
    public GameObject playerHand;


    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick(){

        this.gameObject.transform.position = playerHand.transform.position;
        Debug.Log("onPointerClick");
    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        Debug.Log("Holalala");
    }
}
