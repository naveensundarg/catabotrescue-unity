using UnityEngine;
using System.Collections;
using System;
public class Catabot :MonoBehaviour  {
	public static float dampingRatio=0.5f;
	static float _blockOffset=0;
	static float _limbOffsetUpper=0;
	static float _limbOffsetLower=0;
	static float _xPos;
	static float D =.132f;
	static int id=0;

	public float fullWidth;
	public float halfHeight;
	public int[] specs;
	public float rightSide;
	public float leftSide;

	private bool _angry;
	private Controller controller;
	private static Sprite[] _headSprites;

	protected GameObject head;
	void Start () 
	{
		_angry = false;
		Invoke ("changeHead",UnityEngine.Random.Range (1,2));
		controller =(Controller) GameObject.FindGameObjectWithTag ("Controller").GetComponent<Controller> ();


	}
	void Update(){
	}
	public void selectedHead(){
			head.GetComponent<SpriteRenderer> ().sprite = controller.selecteHeadSprite;

	}
	public void setAngryHead(){
		head.GetComponent<SpriteRenderer> ().sprite = controller.angryHeadSprite;
		_angry = true;
	}
	public void deSelectedHead(){
		head.GetComponent<SpriteRenderer> ().sprite = controller.normalHeadSprite;

		Invoke ("changeHead",UnityEngine.Random.Range (1,2));
	}

	public void setNormalHead(){
		head.GetComponent<SpriteRenderer> ().sprite = controller.normalHeadSprite;
		_angry = false;
		Invoke ("changeHead",UnityEngine.Random.Range (1,2));
	}
	public void changeHead(){
		Debug.Log ("Changing Head");
		if (!gameObject.GetComponent<Drag> ().getSelected ()&& !_angry)

		{
			head.GetComponent<SpriteRenderer> ().sprite = controller.headSprites [UnityEngine.Random.Range (0, controller.headSprites.Length)];
			Invoke ("changeHead", UnityEngine.Random.Range (0.5f, 3));
		}

	}
	public static GameObject createCatabot(int[] specs, Controller controller){
		_headSprites = Resources.LoadAll<Sprite>("Assets/Resources/Sprites/rdg_head_anims.png"); 
		Debug.Log("HeadSprites Count "+_headSprites.Length);
		GameObject catabot = new GameObject("Catabot ["+string.Join(",", Array.ConvertAll(specs, x => x.ToString()))+"] ID:"+id++);
		float width=0f;
		float height=0f;
		float headWidth=0;
		float _xOffset=-1;
		float _leftSide=0;

		
		catabot.AddComponent<Catabot>();
		catabot.GetComponent<Catabot>().specs=specs;
		GameObject head = new GameObject("Head");
		
		addPhysicsAndParent(head,catabot,false,false,catabot);
		head.AddComponent<SpriteRenderer>();
		SpriteRenderer renderer = head.GetComponent<SpriteRenderer>();
		renderer.sprite = controller.headSprites[0];
		head.AddComponent<CircleCollider2D>();
		GameObject dummyblock = new GameObject("[Block "+1 +"]");
		addSprite(dummyblock,controller.blockSprite);
		addPhysicsAndParent(dummyblock,catabot,false,true,catabot);
		width=width+getSpriteWidth(dummyblock);//blockRenderer.bounds.size.x;

		headWidth= getSpriteWidth(head);//headRenderer.bounds.size.x;
		height=getSpriteHeight(dummyblock);
		head.transform.localPosition=new Vector2(head.transform.localPosition.y-width/2-headWidth/2, head.transform.localPosition.y);
		_xOffset=width/2;//+headWidth/2;
		
		_leftSide=headWidth+0.5f*getSpriteWidth(dummyblock);
		
		catabot.GetComponent<Catabot> ().head = head;
		width = width - getSpriteWidth (dummyblock);
		Destroy (dummyblock);

		//addSprite(catabot,""
		for(int i = 0; i < specs.Length; i++){

			GameObject block = new GameObject("[Block "+specs[i] +"]");
			addSprite(block,controller.blockSprite);
			width=width+getSpriteWidth(block);//blockRenderer.bounds.size.x;

			if(i==0){
				//Adding the first block

			}

			addPhysicsAndParent(block,catabot,false,true,catabot);

			block.AddComponent<Block>();
			block.GetComponent<Block>().limbs=specs[i];
			block.GetComponent<Block>().location=i;
			_limbOffsetUpper=0;
			_limbOffsetLower=0;
			addLimbs(specs[i],block,controller,catabot);

			placeBlock (block);
		}
				catabot.AddComponent<SpringJoint2D> ();
		catabot.AddComponent<Drag>();
		catabot.GetComponent<Drag> ().catabot = catabot;;
		catabot.AddComponent<Rigidbody2D>();
		catabot.AddComponent<BoxCollider2D>();

		catabot.rigidbody2D.isKinematic=true;
		BoxCollider2D collider=catabot.GetComponent<BoxCollider2D>();
		collider.size= new Vector2(width,height);//1.45f);//Magic number hack!
		collider.center=new Vector2(width/2-_xOffset,0);

		catabot.GetComponent<Catabot> ().rightSide = width-_xOffset;
		catabot.GetComponent<Catabot> ().leftSide=_leftSide;
		catabot.GetComponent<Catabot> ().fullWidth = width + headWidth;
		catabot.GetComponent<Catabot> ().halfHeight = height * .5f;


		_xPos=0;
		_blockOffset=0;
		catabot.GetComponent<Catabot>().controller=controller;
		////catabot.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		return catabot;
	}



	public void drag(Vector2 disp){

		transform.position=new Vector2(transform.position.x,transform.position.y) + disp;

	}

	private static void addSprite(GameObject obj, Sprite sprite){

		obj.AddComponent<SpriteRenderer>();
		SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();

		renderer.sprite = sprite;


	}


	private static void addLimbs(int limbs, GameObject block,Controller controller, GameObject catabot){

		string limbSpriteName="Assets/Resources/Sprites/";
		if (limbs>0) limbSpriteName+="hand_pos_";
		else limbSpriteName+="hand_neg_";

		// i => -(i-1)D : 2D: (i-1)D 
		/// D=0.2
		/// 
		_xPos=-((Mathf.Abs(limbs)-1))*D;

		for(int i=0; i< Mathf.Abs(limbs); i++){

			SpriteRenderer blockRenderer = block.GetComponent<SpriteRenderer>();

			GameObject limbUpper = new GameObject("limb");

			if(limbs>0)addSprite(limbUpper,controller.handPos1); 
			else addSprite(limbUpper,controller.handNeg1);
			addPhysicsAndParent(limbUpper,block,true,false,catabot);
			limbUpper.AddComponent<Limb>();
			

			GameObject limbLower = new GameObject("limb");
			if(limbs>0)addSprite(limbLower,controller.handPos2);
				else addSprite(limbLower,controller.handNeg2);

			addPhysicsAndParent(limbLower,block, true,false,catabot);
			limbLower.AddComponent<Limb>();


			placeLimbs(limbUpper,-blockRenderer.bounds.max.y,limbLower,blockRenderer.bounds.max.y);

		}


	}

	private static void addPhysicsAndParent(GameObject child, GameObject parent,bool isTrigger, bool isBlock, GameObject catabot){

		child.AddComponent<Drag>();
		child.GetComponent<Drag> ().catabot = catabot;
		child.AddComponent<Rigidbody2D>();
		child.rigidbody2D.isKinematic=!isBlock;
		child.rigidbody2D.gravityScale=0;
		child.rigidbody2D.mass=0;
		child.AddComponent<BoxCollider2D>();
//		child.rigidbody2D.isKinematic=!]t;

		child.collider2D.isTrigger=true;
		child.transform.parent=parent.transform;

		if(isBlock){

			BoxCollider2D boxcollider=child.GetComponent<BoxCollider2D>();
			boxcollider.size= new Vector2(1.0f, 1.75f);

		}

	}
	

	private static void placeBlock(GameObject block){
		block.transform.position=new Vector2(block.transform.position.x+_blockOffset,block.transform.position.y);
		//SpriteRenderer renderer = block.GetComponent<SpriteRenderer>();	
		_blockOffset=_blockOffset+ getSpriteWidth(block);//+renderer.bounds.size.x;
		
	}


	private static void placeLimbs(GameObject limbUpper, float yUpper,GameObject limbLower,float yLower ){
		
		limbUpper.transform.localPosition=new Vector2(limbUpper.transform.localPosition.x+_xPos, yUpper);
		limbLower.transform.localPosition=new Vector2(limbLower.transform.localPosition.x+_xPos, yLower);

		_xPos=_xPos+2*D;
		
	}
	private static void placeLimbUpper(GameObject limb, float y){

		limb.transform.localPosition=new Vector2(limb.transform.localPosition.x+_xPos, y);
		SpriteRenderer renderer = limb.GetComponent<SpriteRenderer>();	
		_limbOffsetUpper=_limbOffsetUpper+renderer.bounds.extents.x;
			_xPos=_xPos+2*D;
		
	}


	private static void placeLimbLower(GameObject limb, float y){
		
		limb.transform.localPosition=new Vector2(limb.transform.localPosition.x+_limbOffsetLower, y);
		SpriteRenderer renderer = limb.GetComponent<SpriteRenderer>();	
		_limbOffsetLower=_limbOffsetLower+renderer.bounds.extents.x;
		
	}
	private static float getSpriteHeight(GameObject obj){
		SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();	
		
		return renderer.bounds.size.y;
	}
	

	private static float getSpriteWidth(GameObject obj){
		SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();	

		return renderer.bounds.size.x;
	}

}
