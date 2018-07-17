using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {

    public Texture imagem;

	// Use this for initialization
	void Start ()
    {
        Material material = new Material(Shader.Find("Diffuse"));
        material.mainTexture = imagem;
        gameObject.GetComponent<Renderer>().material = material;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
