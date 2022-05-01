using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class modelDisplay : MonoBehaviour
{
    [SerializeField] private Text nameObject;
    [SerializeField] private Image infoObject;
    [SerializeField] private Transform modelHolder;

    public void DisplayObject(PartesScrepitable _partes){

        nameObject.text = _partes.nameObject;
        infoObject.sprite = _partes.infoObject;

        if (modelHolder.childCount > 0 )
            Destroy(modelHolder.GetChild(0).gameObject);

        Instantiate(_partes.modelObject, modelHolder.position, modelHolder.rotation, modelHolder);

    }       
}
