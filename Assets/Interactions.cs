using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour {
	public GameObject Mol1;
	public GameObject Mol2;
	public GameObject Mol3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1"))
			{
			Mol2.SetActive(false);
			Mol3.SetActive(false);
			Mol1.transform.Translate(6.0f,1.2f,0);

		}

	}
}
