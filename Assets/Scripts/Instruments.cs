using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Instruments : MonoBehaviour, IPointerClickHandler
{
    public GameObject instrumentsUI;
    public GameObject unpauseButton;
    public GameObject dialog;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerClick.gameObject.name);
        instrumentsUI.SetActive(false);
        unpauseButton.SetActive(true);
        dialog.SetActive(true);
    }
}
