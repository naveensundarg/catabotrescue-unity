using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public int limbs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		GameObject otherObj=other.gameObject;
		if(otherObj.GetComponent<Block>() != null)
		{
			Debug.Log("Colliding with another block");
		}
	}
}
