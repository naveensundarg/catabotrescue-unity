using UnityEngine;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

public class HomeController : MonoBehaviour {

	public GUIStyle emailFieldStyle;
	private string email = "";
	// Use this for initialization
	void Start () {
	
		if (PlayerPrefs.HasKey ("UserId")) {
			Controller.UserID=PlayerPrefs.GetString ("UserId");
			Application.LoadLevel("main");
			Debug.Log("logged in already");

		}
		else
			Debug.Log("not logged in already");


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.skin.label.normal.textColor = Color.black;
		GUI.skin.label.fontStyle=FontStyle.Bold;

		GUI.skin.label.normal.textColor = Color.black;
		GUI.skin.label.hover.textColor = Color.gray;
		GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 2, 95, 30), "Login(Email)");
		email = GUI.TextField(new Rect(Screen.width/2, Screen.height/2, 200, 30), email, 50);

		if(GUI.Button(new Rect(Screen.width/2+210, Screen.height/2, 50, 30), "Go")){

			GoPressed ();

		}
	}


	void GoPressed(){

		if (isEmailValid(email)) {

			Cloud.createUser(email);
			Controller.UserID=email;
			Application.LoadLevel("main");
		}

	}

	bool isEmailValid(string email){
		try
		{
			return true;
		}
		catch (System.FormatException)
		{
			return false;
		}

	//	return true;
	}




}
