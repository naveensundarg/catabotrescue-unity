using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
	
	private bool _selected=false;
	private Vector2 _lastTouch;
	private Controller _controller;
	private SpringJoint2D spring;
	private bool _active;
	private Catabot catabotComp;
	public GameObject catabot;
	float doorLeft=0.475f;
	float doorRight = 0.525f;

	void Awake()
	{
		_controller = GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
	//		
	}

	void Start(){

		catabotComp = catabot.GetComponent<Catabot> ();

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
		Vector2 pleft = Camera.main.WorldToViewportPoint (new Vector2 (dragabble.transform.position.x - catabotComp.leftSide, dragabble.transform.position.y) 
						+ delta); 
		Vector2 pright = Camera.main.WorldToViewportPoint(new Vector2 (dragabble.transform.position.x+catabotComp.rightSide, dragabble.transform.position.y) + delta); 

		Vector2 ptop = Camera.main.WorldToViewportPoint (new Vector2 (dragabble.transform.position.x , dragabble.transform.position.y+catabotComp.halfHeight) 
		                                                  + delta); 
		Vector2 pbottom = Camera.main.WorldToViewportPoint(new Vector2 (dragabble.transform.position.x, dragabble.transform.position.y-catabotComp.halfHeight) 
		                                                   + delta); 


		if (inView (pleft.x,pright.x,ptop.y,pbottom.y) &&outSideDoor (pleft.x,pright.x,ptop.y,pbottom.y)  &&inputEnabled())
			dragabble.transform.position = new Vector2 (dragabble.transform.position.x, dragabble.transform.position.y) + delta;



	}
	bool inView(float leftEdge, float rightEdge, float topEdge,float BottomEdge){
		return leftEdge>0 && rightEdge <1 && BottomEdge>0 && topEdge<1;


	}

	bool outSideDoor(float leftEdge, float rightEdge, float topEdge,float BottomEdge){

		if ( (leftEdge<doorLeft && rightEdge>doorLeft) || (leftEdge<doorRight && rightEdge>doorRight))
						return BottomEdge > 0.05;
		return true;
	}

	void bringUpTo(int z){

		SpriteRenderer renderer = gameObject.gameObject.GetComponent<SpriteRenderer>();
		if(renderer!=null){
			renderer.sortingOrder=z;
		}

	}

	public void mating(){
		_active=false;
		deselected ();

	}
	void OnMouseUp()     
	{
		_active=false;
		deselected ();

	}
	public void selected(){
		_selected = true;
		if (gameObject != catabot) {
						catabot.GetComponent<Drag> ().selected ();	
				
				} 
		else {
		
			gameObject.GetComponent<Catabot>().selectedHead();
		
		}
	}

	public bool inputEnabled(){
		return _controller.inputEnabled;
	}
	public void deselected(){
		_selected = false;
		if(gameObject!=catabot)
		catabot.GetComponent<Drag> ().deselected ();	
		else {
			
			gameObject.GetComponent<Catabot>().deSelectedHead();
			
		}

	}

}
