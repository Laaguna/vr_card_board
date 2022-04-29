using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    public Transform playerRoot, irAJugar_Position;
    public Animator animatorPlayer;
    public GameObject panelPrincipal;

   public void IrAJugar(){
       playerRoot.transform.position = irAJugar_Position.transform.position;
       panelPrincipal.SetActive(false);
   }

   public void IrAPartes(){

   }
}
