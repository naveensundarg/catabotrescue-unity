using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
	
	private bool _selected=false;
	private Vector2 _lastTouch;
	private Controller _controller;
	private SpringJoint2D spring;
	private bool _active;

	public GameObject catabot;
	void Awake()
	{

		_controller = GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
	//		
	}

	public bool getSelected(){
		if(gameObject==catabot)
		   return _selected;
		   else
		   return catabot.GetComponent<Drag>().getSelected();
	}
	
	void OnMouseDown()
	{
		_active=true;
		selected ();
		_lastTouch=Camera.main.ScreenToWorldPoint (Input.mousePosition);
		_controller.maxZ=_controller.maxZ+1;

		transform.root.gameObject.BroadcastMessage("bringUpTo",_controller.maxZ);
			
	}
	

	void FixedUpdate(){
		if (_active && inputEnabled() ) 
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);//getting cursor position
			dragRootBy(cursorPosition-_lastTouch);
			_lastTouch=cursorPosition;
			
		}
	
	}

	void OnMouseDrag()     
	{
		

	}
	
	public void dragRootBy(Vector2 delta){
		GameObject dragabble = gameObject.transform.root.gameObject;

		dragabble.transform.position = new Vector2 (dragabble.transform.position.x, dragabble.transform.position.y) + delta;

	}
	void bringUpTo(int z){

		SpriteRenderer renderer = gameObject.gameObject.GetComponent<SpriteRenderer>();
		if(renderer!=null){
			renderer.sortingOrder=z;
		}

	}

	void OnMouseUp()     
	{
		_active=false;
		deselected ();

	}
	public void selected(){
		_selected = true;
		if(gameObject!=catabot)
			catabot.GetComponent<Drag> ().selected ();	

	}

	public bool inputEnabled(){
		return _controller.inputEnabled;
	}
	public void deselected(){
		_selected = false;
		if(gameObject!=catabot)
		catabot.GetComponent<Drag> ().deselected ();	

	}

}
