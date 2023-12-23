using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour, IPointerClickHandler
{
    public GameObject instrumentsUI;
    public GameObject dialog;
    public GameObject unpauseButton;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(active_no());
        IEnumerator active_no()
        {
            yield return new WaitForSeconds (0.6F);
            instrumentsUI.SetActive(true);
            unpauseButton.SetActive(false);
            dialog.SetActive(false);
        }
        
    }

    public void CloseInstruments()
    {
        instrumentsUI.SetActive(false);
        unpauseButton.SetActive(true);
        dialog.SetActive(true);
    }
}
