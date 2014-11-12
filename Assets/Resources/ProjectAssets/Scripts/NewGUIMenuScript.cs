using UnityEngine;
using System.Collections;

public class NewGUIMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.F1) || Input.GetKeyUp(KeyCode.Escape)) {
			//this.gameObject.layer = transparent;
		}

	}
}
