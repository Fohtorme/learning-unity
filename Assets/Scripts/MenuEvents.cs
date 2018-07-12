using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEvents : MonoBehaviour {
    // Text events
    public Text eventsLog;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestStagesButton()
    {
        setEventsLogText("TestStagesButton()");
    }

    public void UITestButton()
    {
        setEventsLogText("UITestButton()");
    }

    public void OptionsButton()
    {
        setEventsLogText("OptionsButton()");
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
