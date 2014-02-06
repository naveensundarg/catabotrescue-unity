using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public Sprite[] headSprites;
	public Sprite blockSprite;
	public Sprite handNeg1,handNeg2,handPos1,handPos2;
	public int maxZ=0;

	// Use this for initialization
	void Start () {

		int[] bot1 = new int[] { 1, -4};
		Catabot.createCatabot(bot1,this);


		int[] bot2 = new int[] { 3, 1};
		Catabot.createCatabot(bot2,this);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
