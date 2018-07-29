using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Interactions : MonoBehaviour {
    public GameObject WholeMol;
    public GameObject Mol1;
	public GameObject Mol2;
	public GameObject Mol3;
    public GameObject Mol4;
    public GameObject Mol5;
    public GameObject Mol6;
    public float RoSpeed = 1.0f;
    public float ManRo = 5.0f;
    public float FadeperSec = 3.0f;
    public float ScaleUp = 0.1f;
    public float ScaleDown = -0.1f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        WholeMol.transform.Rotate(Vector3.up * Time.deltaTime * RoSpeed);

        if (Input.GetKeyDown("1"))
        {
            Mol2.SetActive(false);
            Mol3.SetActive(false);
            Mol4.SetActive(false);
            Mol5.SetActive(false);
            Mol6.SetActive(false);

        }

        // If IsUsing is true then activate object's child canvas
        
        //If gamepad is pressed while isUsing is true then deactivate other Mols 

        //When one Mol is selected move label to top right, show back button, display new text and play audio
    
        //scale Change Mol
        if (Input.GetKeyDown("p"))
        {
            WholeMol.transform.localScale += new Vector3(ScaleUp, ScaleUp, ScaleUp);
        }
        if (Input.GetKeyDown("l"))
        {
            WholeMol.transform.localScale += new Vector3(ScaleDown, ScaleDown, ScaleDown);
        }

        //manually rotate Mol
        if (Input.GetKeyDown("n"))
        {
            WholeMol.transform.Rotate(Vector3.up * ManRo);
        }
        if (Input.GetKeyDown("m"))
        {
            WholeMol.transform.Rotate(Vector3.up * -ManRo);
        }
    }
}
