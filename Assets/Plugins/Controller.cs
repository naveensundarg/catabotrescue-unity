using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using SimpleJSON;

public class Controller : MonoBehaviour {

	public  static String UserID="";

	public GUIText prisonLabel;
	public string levelSpecs;
	public Sprite[] headSprites;
	public Sprite blockSprite;
	public Sprite handNeg1,handNeg2,handPos1,handPos2;
	public int maxZ=0;
	public Sprite selecteHeadSprite,angryHeadSprite, normalHeadSprite;
	public GameObject undoButton, redoButton, resetButton;
	public Texture undoDisabled, redoDisabled;
	public Material lineMaterial;
	public GUIStyle undoButtonStyle;
	public GUIStyle redoButtonStyle;
	private GUIStyle _emptyStyle=new GUIStyle();
	public Stack<GameObject> history;
	private Stack<GameObject> future;
	private JSONNode _levelsJson;

	private Stack<GameObject> starting;
	private int finalLevel;
	private int _currentLevel=1;
	private int _totalMoves = 0;
	private Rect _undoRect =new Rect (10, 0, 50, 50);
	private Rect _redoRect = new  Rect (60, 0, 50, 50);

	public bool inputEnabled { get; set;}
	private bool _finalAnim;
	private GameObject finalHead;
	private float _startTime;
	private GameObject child;

	private string log;
	// Use this for initialization
	void Start () {
		inputEnabled = true;
		_finalAnim = false;
		_levelsJson=JSON.Parse(levelSpecs);
		finalLevel = _levelsJson.Count;
		history=new Stack<GameObject>();
		future=new Stack<GameObject>();
		_currentLevel = Cloud.maxLevelCompleted(UserID) ;

		
		loadNewLevel(_currentLevel);
//		int[] bot1 = new int[] { 1, -4};
//		placeRandomly(Catabot.createCatabot(bot1,this));
//		int[] bot2 = new int[] { 4, 1};
//		placeRandomly(Catabot.createCatabot(bot2,this));

		undoButton.GetComponent<ButtonBehavior>().disabled=true;
		undoButton.GetComponent<ButtonBehavior>().action="undo";

		redoButton.GetComponent<ButtonBehavior>().disabled=true;
		redoButton.GetComponent<ButtonBehavior>().action="redo";

		GameObject dummy = new GameObject ();
		dummy.AddComponent<SpriteRenderer> ();;
		dummy.GetComponent<SpriteRenderer> ().sprite = normalHeadSprite;

		float headWidth =30 ;//Camera.main.WorldToScreenPoint(new Vector3(dummy.GetComponent<SpriteRenderer> ().bounds.size.x,0,0));
		Debug.Log ("Headwidth = " + headWidth);
		Destroy (dummy);

		//placeLine (Camera.main.ScreenToWorldPoint(new Vector3 (0, 60, 10)), Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width/2-headWidth/2,60, 10)), 0.1f);
		//placeLine (Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width/2+headWidth/2, 60, 10)), Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width,60, 10)), 0.1f);


	}
	
	// Update is called once per frame
	void Update () {

		if (_finalAnim)
						finalHeadAnim ();
	
	}


	public GameObject UpdateHistory(GameObject obj){
		history.Push(obj);
		if(undoButton.GetComponent<ButtonBehavior>().disabled){

			undoButton.GetComponent<ButtonBehavior>().disabled=false;
		}

		future.Clear();

		return obj;
	}

	bool canUndo(){ return history.Count>0;}
	bool canRedo(){ return future.Count>0;}

	public GameObject Undo()
	{
		GameObject obj=null;
		if(history.Count>0){
			obj= history.Pop();
			obj.SetActive(false);
			future.Push(obj);
			redoButton.GetComponent<ButtonBehavior>().disabled=false;
			_totalMoves--;
		}
		if(history.Count==0){
			undoButton.GetComponent<ButtonBehavior>().disabled=true;

		}
		return obj;
	}

	public GameObject Redo(){
		GameObject obj=null;
		if(future.Count>0){
			obj= future.Pop();
			history.Push(obj);
			obj.SetActive(true);
			undoButton.GetComponent<ButtonBehavior>().disabled=false;
			_totalMoves++;
		}
		if(future.Count==0){
			redoButton.GetComponent<ButtonBehavior>().disabled=true;
			
		}
		return obj;
		
	}

	private void clearFuture(){

		future.Clear ();
	}

	public void reproduce(GameObject c1, GameObject c2, int a, int b){

		int[] specs1= c1.GetComponent<Catabot>().specs;
		int[] specs2= c2.GetComponent<Catabot>().specs;

		int[] merged = mergeSpecs (specs1, specs2, a, b);

		gamelog ("["+System.DateTime.UtcNow+": Merging " + printArray (specs1) + printArray (specs2)+"]\n");
		clearFuture ();
		_totalMoves++;
		        // child;
		if (merged.Length > 0)
		{
//			float c1x=c1.transform.position.x-c1.GetComponent<Catabot>().leftSide;
//			float c2x=c2.transform.position.x-c2.GetComponent<Catabot>().leftSide;
//
//
//			float c1y=c1.transform.position.y;
//			float c2y=c2.transform.position.y;
					 child = UpdateHistory (Catabot.createCatabot (merged, this));
//
//			GameObject child = UpdateHistory (Catabot.createCatabot (merged, this));
//			child.transform.position=new Vector2(Mathf.Min(c1x,c2x)-child.GetComponent<Catabot>().rightSide,
//			                                     c1y*0.5f+c2y*0.5f);
			float c1x=c1.transform.position.x-c1.GetComponent<Catabot>().leftSide;
			float c2x=c2.transform.position.x-c2.GetComponent<Catabot>().leftSide;
			
			
			float c1y=c1.transform.position.y;
			float c2y=c2.transform.position.y;
			
			
			
			child.transform.position=new Vector2(Mathf.Min(c1x,c2x)-child.GetComponent<Catabot>().rightSide,
			                                     c1y*0.5f+c2y*0.5f);
		}
		else {
			startHeadAnim();
			child=finalHead;

			float c1x=c1.transform.position.x-c1.GetComponent<Catabot>().leftSide;
			float c2x=c2.transform.position.x-c2.GetComponent<Catabot>().leftSide;
			
			
			float c1y=c1.transform.position.y;
			float c2y=c2.transform.position.y;
			
			
			
			finalHead.transform.position=new Vector2(Mathf.Min(c1x,c2x)-child.GetComponent<Catabot>().rightSide,
			             
			                                     c1y*0.5f+c2y*0.5f);

			_startTime = Time.time;

			_finalAnim=true;

			//Invoke("finishLevel",1);	
		}


	}

	private void loadNewLevel(int level){
		clearLevel();

		prisonLabel.text = "Prison: " + _currentLevel;
	
		PlayerPrefs.SetInt("CurrentLevel", _currentLevel);
		PlayerPrefs.Save ();

		int[][] catabots = getLevel(level);
		starting = new Stack<GameObject> ();
		for (int c = 0; c < catabots.Length; c++){

			starting.Push(placeRandomly(Catabot.createCatabot(catabots[c],this)));
		}
		inputEnabled = true;


	}

	private void clearLevel(){
		inputEnabled = true;
		log = "";
		_totalMoves = 0;
		while (history.Count>0) 
			Destroy(history.Pop());		
		while (starting!=null && starting.Count>0) 
			Destroy(starting.Pop());	

	}

	private void finishLevel(){

		Cloud.saveLevel (UserID, _currentLevel, log,_totalMoves);

		inputEnabled = true;
		if(_currentLevel!=finalLevel){

			_currentLevel++;
			inputEnabled=true;


			loadNewLevel(_currentLevel);
		}
		else
		{
			Application.LoadLevel("home");
		}

	}

	private string printArray(int[] s){
		string p="[";
		foreach(int i in s){
			p=p+i + " ";
		}
		p = p + "]";
		Debug.Log (p);
		return p;
	}

	private void gamelog(string message){
		log = log + message;
	}
	private int[] mergeSpecs(int[] specs1, int[] specs2, int a, int b){


		HashSet<int> limbs=new HashSet<int>();
		int[] specs = new int[specs1.Length+specs2.Length-2];
		int index=0;
		for (int i = 0; i < specs1.Length;i++){
			if(i!=a & !limbs.Contains(specs1[i]))
			{

				specs[index]=specs1[i];
				limbs.Add(specs1[i]);
				index++;
			}

		}

		for (int i = 0; i < specs2.Length;i++){
			if(i!=b & !limbs.Contains(specs2[i]))
			{
				specs[index]=specs2[i];
				limbs.Add(specs2[i]);
				index++;
			}
			
		}

		Array.Resize(ref specs, index);
		return specs;

	}




	GameObject placeRandomly(GameObject obj){
		float screenWidth = Camera.main.pixelWidth;
		float screenHeight= Camera.main.pixelHeight;

		Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2 (UnityEngine.Random.Range (0.2f *	 screenWidth, 0.8f * screenWidth),
		                                      UnityEngine.Random.Range(0.2f * screenHeight, 0.8f * screenHeight)
		                                                                     ));
		obj.transform.position = new Vector3 (pos.x, pos.y, 0);

		return obj;
	}


	int[][] getLevel(int level){
		JSONArray catabotSpecs = _levelsJson["Level_"+level].AsArray;

		int[][] levelSpecs= new int[catabotSpecs.Count][];

		for(int c = 0; c<catabotSpecs.Count;c++){
			string currentCatabot = catabotSpecs[c];
			string[] blocks = currentCatabot.Split('|');
			levelSpecs[c]=new int[blocks.Length];
			for (int b = 0; b<blocks.Length;b++){
				levelSpecs[c][b]=int.Parse(blocks[b]);

			}

		}
		//gameObject.GetComponent<Levels> ().getLevel (level);
		//int[][] levels =(int[][]) levelsJson.GetObject("Levels_"+level);
		return levelSpecs;
	}

	void placeLine(Vector3 p1, Vector3 p2, float width){
		GameObject obj = new GameObject ("line from"+p1 +"to"+ p2);
		obj.AddComponent<LineRenderer> ();
		LineRenderer lineRenderer = obj.GetComponent<LineRenderer> ();
		lineRenderer.SetColors (Color.gray, Color.gray);

		lineRenderer.SetPosition (0, p1);
		lineRenderer.SetPosition (1, p2);
		lineRenderer.SetWidth (width, width);
		lineRenderer.material = lineMaterial;
		obj.AddComponent<BoxCollider2D> ();
	}


	void startHeadAnim(){
		finalHead = Catabot.createCatabot(new int[0],this);
	//	_finalAnim = true;
	}

	void finalHeadAnim(){

				
		float yVelocity = 0.0F;
		float smoothTime = 5f;
		float maxSpeed=0.1f;
		float t = (Time.time - _startTime) / smoothTime;
		Debug.Log ("Time t " + t);

		float finalX = 0;;
		float finalY = -9.5f;

		Debug.Log("In final Head Anim");
		finalHead.transform.position = new Vector2(Mathf.SmoothStep(finalHead.transform.position.x, finalX, t),
		                                           Mathf.SmoothStep(finalHead.transform.position.y, finalY, t));
		//gameObject.GetComponent<Drag>().mating();
		if (finalHead.transform.position.y == finalY) {
			_finalAnim=false;	
			finishLevel();
			Destroy(finalHead);

		}
	}	


	void OnGUI (){
		GUI.skin = null;
		GUI.skin.label.normal.textColor = Color.black;
		GUI.BeginGroup(new Rect(0, 0, Screen.width, 100));
		GUI.Label (new Rect (0, 0, 400, 100), "User ID:" + UserID);		
		GUI.EndGroup ();



		GUI.BeginGroup(new Rect(0, Screen.height-50, Screen.width, 100));

		if (!canUndo()) 
			GUI.Button (_undoRect,  undoDisabled,_emptyStyle);

		if (!canRedo()) 
			GUI.Button (_redoRect,  redoDisabled,_emptyStyle);
		
		if (canUndo()&& GUI.Button (_undoRect, "", undoButtonStyle)) 
			Undo();
				
		if (canRedo () && GUI.Button (_redoRect, "", redoButtonStyle)) 
			Redo ();

	
		GUI.EndGroup ();


	}



}



