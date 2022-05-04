using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{

    #region Limit FPS

    public int targetFrameRate = 30;
 
     private void Start()
     {
         QualitySettings.vSyncCount = 0;
         Application.targetFrameRate = targetFrameRate;
     }

    #endregion

    public Transform playerRoot, irAJugar_Position;
    public GameObject panelPrincipal, panelInventario, panelBack;

   public void IrAJugar(){
       playerRoot.transform.position = irAJugar_Position.transform.position;
       panelPrincipal.SetActive(false);
   }

   public void IrAPartes(){
       panelPrincipal.SetActive(false);
       panelInventario.SetActive(true);
   }

   public void Back(){
       panelInventario.SetActive(false);
       panelPrincipal.SetActive(true);
   }
}
