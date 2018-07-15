using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour {

    // Game scenes
    private List<string> scenes = new List<string>();

    // Scene button prefab
    public GameObject prefab;

    // Use this for initialization
    void Start()
    {
        // TODO: I need find a way to do it automatically :(
        scenes.Add("Assets/000.Menu/000.Menu.unity");
        scenes.Add("Assets/001.TPS/001.TPS.unity");

        // Create buttons according the scenes
        CreateSceneButtons();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void CreateSceneButtons()
    {
        // Create buttons from prefab
        // OBS: The button needs to have a Layout compontent specifying them height
        foreach (string scene in scenes)
        {
            GameObject newButton = GameObject.Instantiate(prefab);
            newButton.transform.SetParent(gameObject.transform);
            newButton.GetComponent<Button>().onClick.AddListener(() => LoadScene(scene));
            Text tx = newButton.transform.GetComponentInChildren<Text>();
            tx.text = scene;
        }
    }
    
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
