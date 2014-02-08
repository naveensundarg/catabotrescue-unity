using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
	
	private bool _selected=false;
	private Vector2 _lastTouch;
	private Controller _controller;

	void Awake()
	{

		_controller = GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
//		
//		spring = this.gameObject.GetComponent<SpringJoint2D>(); //"spring" is the SpringJoint2D component that I added to my object
//		
//		spring.connectedAnchor = gameObject.transform.position;//i want the anchor position to start at the object's position
//		
	}
	
	
	void OnMouseDown()
	{
		_selected=true;
		_lastTouch=Camera.main.ScreenToWorldPoint (Input.mousePosition);
		_controller.maxZ=_controller.maxZ+1;

		transform.root.gameObject.BroadcastMessage("bringUpTo",_controller.maxZ);
//		spring.enabled = true;//I'm reactivating the SpringJoint2D component each time I'm clicking on my object becouse I'm disabling it after I'm releasing the mouse click so it will fly in the direction i was moving my mouse
		
	}
	

	void FixedUpdate(){
		if (_selected ) 
		{
			
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);//getting cursor position
			
			//transform.position=cursorPosition;
			
			dragRoot(gameObject, cursorPosition);
			
			//spring.connectedAnchor = cursorPosition;//the anchor get's cursor's position
			_lastTouch=cursorPosition;
			
		}
	
	}

	void OnMouseDrag()     
	{
		

	}
	
	void dragRoot(GameObject obj,Vector2 cursorPosition){

		
		GameObject root= obj.transform.root.gameObject;
		root.transform.position=new Vector2(root.transform.position.x,root.transform.position.y) + (cursorPosition-_lastTouch);
		//root.transform.position=new Vector3(root.transform.position.x,root.transform.position.y,1);


	}
	void bringUpTo(int z){

		SpriteRenderer renderer = gameObject.gameObject.GetComponent<SpriteRenderer>();
		if(renderer!=null){
			renderer.sortingOrder=z;
		}

	}


	void OnMouseUp()     
	{
		_selected=false;

//		spring.enabled = false;//disabling the spring component
		
	}
	
}
