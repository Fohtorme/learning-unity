using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("000.Menu");
    }

}
