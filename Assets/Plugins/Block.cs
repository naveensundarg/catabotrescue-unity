using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public int limbs;
	public int location;
	private Controller _controller; 
	// Use this for initialization
	void Start () {
		Debug.Log("Initializing block behaviour.");
		_controller=GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {

		GameObject otherObj=other.gameObject;
		if(otherObj.GetComponent<Block>() != null)
		{
			if(otherObj.transform.root.position.y<transform.root.position.y)
			{
			Debug.Log("Colliding with another block");
			if(otherObj.GetComponent<Block>().limbs==-limbs){

				Debug.Log ("Reproduction!");

				_controller.reproduce(gameObject.transform.root.gameObject,otherObj.transform.root.gameObject,location, otherObj.GetComponent<Block>().location);

				}
			}

		}
	}
}
