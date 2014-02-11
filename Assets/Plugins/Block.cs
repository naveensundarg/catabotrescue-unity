using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public int limbs;
	public int location;
	private Controller _controller; 
	private GameObject _retractionTrigger;
	private const float THRESHOLD_DISTANCE_UPPER =3f;
	private const float THRESHOLD_DISTANCE_LOWER =2.6f;

	private const float SEPARATION_DISTANCE = 1.285f;
	private GameObject currentMate;
	private bool _mated;
	// Use this for initialization
	void Start () {
		Debug.Log("Initializing block behaviour.");
		_controller=GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
		_mated = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {

		GameObject otherObj=other.gameObject;
		if(otherObj.GetComponent<Block>() != null)
		{
			Debug.Log("Colliding with another block");
			if(otherObj.GetComponent<Block>().limbs==-limbs ) 
			{
				Debug.Log ("Possible Mate!");

				if(otherObj.transform.root.position.y<transform.root.position.y)
				{

				}
			}
			else{
				Debug.Log ("RetractLimbs!");
				_retractionTrigger=other.gameObject;
				gameObject.BroadcastMessage("RetractLimbs");
			}




		}
	}

	bool matingDistance(GameObject other){

		Vector3 p1 = transform.TransformPoint (transform.position);
		Vector3 p2 = other.transform.TransformPoint (other.transform.position);
		
		Debug.Log ("Distance: " + (p1.y- p2.y));

		return THRESHOLD_DISTANCE_LOWER <Mathf.Abs(p1.y-p2.y)
			&& Mathf.Abs(p1.y-p2.y) <THRESHOLD_DISTANCE_UPPER;
	}
	void OnTriggerExit2D (Collider2D other){

		if (_retractionTrigger == other.gameObject) 
			gameObject.BroadcastMessage ("ExtrudeLimbs");
		else 
			_mated = false;


	}

	bool selected(){

		return gameObject.GetComponent<Drag>().getSelected();
	}
	void OnTriggerStay2D (Collider2D other) {
		
		GameObject otherObj=other.gameObject;
		if(otherObj.GetComponent<Block>() != null)
		{
			//Debug.Log("Colliding with another block");
			if(otherObj.GetComponent<Block>().limbs==-limbs)
			{
				if(!selected())
				{

					Debug.Log ("Responsible Reproduction!");
					
					if( matingDistance(otherObj)&& !_mated)
					{
						Debug.Log ("Reproduction!");
						_mated=true;
						float p1 =transform.root.position.y;
						float p2 = otherObj.transform.root.position.y;
						otherObj.transform.root.transform.position = new Vector2(transform.root.position.x,
						                                                         p1<p2?
						                                                         p1+SEPARATION_DISTANCE:p1-SEPARATION_DISTANCE);
						//otherObj.GetComponent<Drag>().dragRootBy(new Vector2(p1.x-p2.x,p1.y-p2.y+2.51f));
						disableInput();

						_controller.reproduce(gameObject.transform.root.gameObject,
						                      otherObj.transform.root.gameObject,
						                      location, 
						                      otherObj.GetComponent<Block>().location);
						currentMate=otherObj;
						Invoke("pushAway",1);
					}
				//	Debug.Log ("Reproduction!");
					
				//	_controller.reproduce(gameObject.transform.root.gameObject,otherObj.transform.root.gameObject,location, otherObj.GetComponent<Block>().location);
					
				}
			}
			else{
				_retractionTrigger=other.gameObject;
				gameObject.BroadcastMessage("RetractLimbs");
			}
			
			
			
			
		}
	}

	void disableInput(){
		_controller.inputEnabled = false;
	}

	void enableInput(){
		_controller.inputEnabled = true;
	}


	void pushAway(){
		float p1 =transform.root.position.y;
		float p2 = currentMate.transform.root.position.y;

		currentMate.transform.root.transform.position = new Vector2(transform.root.position.x,
		                                                         p1<p2?
		                                                         p1+1.4f*SEPARATION_DISTANCE:p1-1.4f*SEPARATION_DISTANCE);

		enableInput ();
	}

}
