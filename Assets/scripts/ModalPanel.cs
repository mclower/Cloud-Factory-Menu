using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ModalPanel : MonoBehaviour {

    public GameObject modalPanelObject;
    public Text description;
    public Button go_back;

    public static ModalPanel modalPanel;

    public static ModalPanel Instance()
    {
        if (!modalPanel)
        {
            modalPanel = FindObjectOfType(typeof(ModalPanel)) as ModalPanel;
            if (!modalPanel)
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
        }

        return modalPanel;
    }
    
    public void Choice(string description, UnityAction cancelEvent)
    {
        modalPanelObject.SetActive(true);

        go_back.onClick.RemoveAllListeners();
        go_back.onClick.AddListener(cancelEvent);
        go_back.onClick.AddListener(ClosePanel);

        this.description.text = description;
        
        go_back.gameObject.SetActive(true);
    }

    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }
}
