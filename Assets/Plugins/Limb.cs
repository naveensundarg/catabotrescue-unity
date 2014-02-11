using UnityEngine;
using System.Collections;

public class Limb : MonoBehaviour {

	// public
	public float retractionSpeed;


	//private 

	private bool retract,extrude;

	private  float _retractedPostion;
	private  float _extrudedPostion;


	// Use this for initialization
	void Start () {

		retract = false;
		extrude = false;
		_retractedPostion = gameObject.transform.localPosition.y > 0 ? 0.11f : -0.11f;
		_extrudedPostion = gameObject.transform.localPosition.y;
		retractionSpeed = 0.05f;
		
	}
	
	// Update is called once per frame
	void Update () {
		float y = transform.localPosition.y;
		if (retract) {

			y=Mathf.MoveTowards(y,_retractedPostion,retractionSpeed);
				
		}
		if (extrude) {
			y=Mathf.MoveTowards(y,_extrudedPostion,retractionSpeed);

		}

		transform.localPosition = new Vector2 (transform.localPosition.x, y);
	
	}

	void RetractLimbs(){
		retract = true;
		extrude = false;
	}

	void ExtrudeLimbs(){
		retract = false;
		extrude = true;
	}
}
