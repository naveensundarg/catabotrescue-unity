using UnityEngine;
using System.Collections;

public class Limb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void RetractLimbs(){

		gameObject.renderer.enabled = false;
		Invoke ("ExtrudeLimbs", 4);
	}

	void ExtrudeLimbs(){
		
		gameObject.renderer.enabled = true;
	}
}
