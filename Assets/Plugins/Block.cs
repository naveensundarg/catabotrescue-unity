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
	public bool _mated;
	private float _blockWidth;
	private Catabot catabot;
	private bool _pushAway;
	private float _startTime;

	private bool entered;
	// Use this for initialization
	void Start () {
		Debug.Log("Initializing block behaviour.");
		_controller=GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
		_mated = false;
		catabot = (Catabot)transform.parent.gameObject.GetComponent<Catabot> ();
		_blockWidth = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
		_pushAway = false;
		entered = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (_pushAway)
				pushAway ();
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		GameObject otherObj=other.gameObject;
		if(otherObj.GetComponent<Block>() != null)
		{
			entered = true;

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
		entered = false;
		if (_retractionTrigger == other.gameObject) {
						gameObject.BroadcastMessage ("ExtrudeLimbs");
						catabot.setNormalHead ();

				} else {	
			_mated = false;
				}

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
					
					if( matingDistance(otherObj)&& !_mated && entered)
					{
						Debug.Log ("Reproduction!");
						_mated=true;
						otherObj.GetComponent<Block>()._mated=true;
						int otherLoc=otherObj.GetComponent<Block>().location;
						float s1 =transform.position.x;
						float s2 = otherObj.transform.position.x;
						float p1 =transform.root.position.y;
						float p2 = otherObj.transform.root.position.y;


						otherObj.transform.root.transform.position = new Vector2(transform.root.transform.position.x+(location-otherLoc)*_blockWidth,
						                                                         p1<p2?
						                                                         p1+SEPARATION_DISTANCE:p1-SEPARATION_DISTANCE);
						//otherObj.GetComponent<Drag>().dragRootBy(new Vector2(p1.x-p2.x,p1.y-p2.y+2.51f));
						disableInput();

						_controller.reproduce(gameObject.transform.root.gameObject,
						                      otherObj.transform.root.gameObject,
						                      location, 
						                      otherLoc);
						currentMate=otherObj;

						Invoke("pushAwayStart",0.5f);
					}
				//	Debug.Log ("Reproduction!");
					
				//	_controller.reproduce(gameObject.transform.root.gameObject,otherObj.transform.root.gameObject,location, otherObj.GetComponent<Block>().location);
					
				}
			}
			else{
				_retractionTrigger=other.gameObject;
				gameObject.BroadcastMessage("RetractLimbs");
				catabot.setAngryHead();
			}
			
			
			
			
		}
	}

	void disableInput(){
		_controller.inputEnabled = false;
	}

	void enableInput(){
		_controller.inputEnabled = true;
	}

	void pushAwayStart(){
		_mated = true;
		_pushAway=true;
		_startTime=Time.time;		

	}

	void pushAway(){


		float p1 =transform.root.position.y;
		float p2 = currentMate.transform.root.position.y;
		 float yVelocity = 0.0F;
		 float smoothTime = 0.5f;
		float maxSpeed=1f;
		float t = (Time.time - _startTime) / smoothTime;
		float finalY = p1 < p2 ?
			p1 + 1.4f * SEPARATION_DISTANCE : p1 - 1.4f * SEPARATION_DISTANCE;
		currentMate.transform.root.transform.position = new Vector2(currentMate.transform.root.position.x,
		                                                            Mathf.SmoothStep(currentMate.transform.root.transform.position.y, 
		                 finalY, t));
		//gameObject.GetComponent<Drag>().mating();
		Debug.Log (currentMate.transform.root.transform.position.y +","+ finalY);
		if (currentMate.transform.root.transform.position.y == finalY) {
			_pushAway=false;		
			enableInput ();
				}
	}

}
