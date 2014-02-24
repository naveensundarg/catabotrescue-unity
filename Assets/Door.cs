using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position=Camera.main.ViewportToWorldPoint(new Vector3(0.5f,0,11));
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D  (Collider2D other) {

		//other.gameObject.GetComponent<Drag> ().hasEnteredDoorRegion ();
		Debug.Log ("Entering Door Region");

	}

	void OnTriggerExit2D  (Collider2D other) {
		
		//other.gameObject.GetComponent<Drag> ().exitedDoorRegion ();
		Debug.Log ("Exiting Door Region");

	}

}
