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


		int[] bot2 = new int[] { 4, 1};
		Catabot.createCatabot(bot2,this);

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void reproduce(GameObject c1, GameObject c2, int a, int b){

		int[] specs1= c1.GetComponent<Catabot>().specs;
		int[] specs2= c2.GetComponent<Catabot>().specs;

		Catabot.createCatabot(mergeSpecs(specs1,specs2,a,b),this);
	}


	private int[] mergeSpecs(int[] specs1, int[] specs2, int a, int b){

		int[] specs = new int[specs1.Length+specs2.Length-2];

		int index=0;
		for (int i = 0; i < specs1.Length;i++){
			if(i!=a)
			{
				specs[index]=specs1[i];
				index++;
			}

		}

		for (int i = 0; i < specs2.Length;i++){
			if(i!=b)
			{
				specs[index]=specs2[i];
				index++;
			}
			
		}
		return specs;

	}

}
