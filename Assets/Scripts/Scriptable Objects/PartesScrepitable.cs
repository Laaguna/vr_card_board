using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PartesScrepitable", menuName = "vr_card_board/PartesScrepitable", order = 0)]
public class PartesScrepitable : ScriptableObject {

    [Header("Information Object")]
    public int indexObject;
    public string nameObject;
    public Sprite infoObject;

    [Header("3D Model")]
    public GameObject modelObject;

    [Header("Audio Source")]
    public AudioSource vozItem;

}
