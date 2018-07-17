using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.GetComponentInChildren<Camera>().projectionMatrix *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
