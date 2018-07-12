using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEvents : MonoBehaviour {
    // Text events
    public Text eventsLog;
    // Current active panel
    private GameObject currentPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CallPanelButton(GameObject panel)
    {
        setEventsLogText("CallPanelButton(" + panel + ")");
        // Desactive the current panel
        if (currentPanel != null)
        {
            currentPanel.SetActive(false);
        }
        // Define new panel as current
        currentPanel = panel;
        // Active panel
        panel.SetActive(true);
    }

    public void QuitButton()
    {
        setEventsLogText("QuitButton()");
        Application.Quit();
    }

    // Change events log text
    private void setEventsLogText(string text)
    {
        if(eventsLog == null)
        {
            return;
        }
        eventsLog.text = text;
    }
}
