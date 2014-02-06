using UnityEngine;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {
	public Sprite normalSprite,selectedSprite,disabledSprite;
	private Sprite currentSprite;

	public bool disabled;
	public string action;

	private Controller controller;
	// Use this for initialization
	void Start () {
	
		disabled=true;
		action="";
		gameObject.GetComponent<SpriteRenderer>().sprite=disabledSprite;
		currentSprite=normalSprite;
		controller= GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>();
		
	}

	void enable(){disabled=false;}
	void disable(){disabled=true;}


	// Update is called once per frame
	void Update () {

		if(disabled) gameObject.GetComponent<SpriteRenderer>().sprite=disabledSprite;
		if(!disabled) 
		{
			gameObject.GetComponent<SpriteRenderer>().sprite=currentSprite;
		}
	
	}

	void OnMouseDown(){

		currentSprite=selectedSprite;
	}

	void OnMouseUpAsButton(){


		currentSprite=normalSprite;

		if(action=="undo"){
			controller.Undo();
			Debug.Log("Undoing");
		};
	}
}
