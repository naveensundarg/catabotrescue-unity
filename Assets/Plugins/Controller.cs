using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Controller : MonoBehaviour {



	public Sprite[] headSprites;
	public Sprite blockSprite;
	public Sprite handNeg1,handNeg2,handPos1,handPos2;
	public int maxZ=0;

	public GameObject undoButton, redoButton, resetButton;

	private Stack<GameObject> history;
	private Stack<GameObject> future;
	

	// Use this for initialization
	void Start () {

		history=new Stack<GameObject>();
		future=new Stack<GameObject>();

		int[] bot1 = new int[] { 1, -4};
		Catabot.createCatabot(bot1,this);
		int[] bot2 = new int[] { 4, 1};
		Catabot.createCatabot(bot2,this);

		undoButton.GetComponent<ButtonBehavior>().disabled=true;
		undoButton.GetComponent<ButtonBehavior>().action="undo";

		redoButton.GetComponent<ButtonBehavior>().disabled=true;
		redoButton.GetComponent<ButtonBehavior>().action="redo";



	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void UpdateHistory(GameObject obj){
		history.Push(obj);
		if(undoButton.GetComponent<ButtonBehavior>().disabled){

			undoButton.GetComponent<ButtonBehavior>().disabled=false;
		}

		future.Clear();
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

		}
		if(future.Count==0){
			redoButton.GetComponent<ButtonBehavior>().disabled=true;
			
		}
		return obj;
		
	}


	public void reproduce(GameObject c1, GameObject c2, int a, int b){

		int[] specs1= c1.GetComponent<Catabot>().specs;
		int[] specs2= c2.GetComponent<Catabot>().specs;

		UpdateHistory(Catabot.createCatabot(mergeSpecs(specs1,specs2,a,b),this));
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



}



