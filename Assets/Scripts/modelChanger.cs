using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] serializeObjects;

    [SerializeField] private modelDisplay modelDisplay;

    private int currentIndex;

    private void Awake() {

        ChangeScriptable(0);
    }

    public void ChangeScriptable(int _change){

        currentIndex += _change;
        
        if(currentIndex < 0) currentIndex = serializeObjects.Length -1;
        else if (currentIndex > serializeObjects.Length - 1) currentIndex = 0;

        if(modelDisplay != null)modelDisplay.DisplayObject((PartesScrepitable)serializeObjects[currentIndex]);
    }
}
