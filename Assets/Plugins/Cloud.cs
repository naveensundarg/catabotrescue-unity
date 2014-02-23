using UnityEngine;
using System.Collections;
using Parse;

public class Cloud : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void createUser(string userID){

		ParseObject currentState = new ParseObject("CurrentState");
		currentState["UserID"] = userID;
		currentState ["level"] = 1;

		currentState.SaveAsync ();

		PlayerPrefs.SetInt ("level", 1);
		PlayerPrefs.SetString("UserId",userID);
		PlayerPrefs.Save();

	}

	public static void saveLevel(string userID, int level, string log, int totalMoves){

		ParseObject levelCompletion = new ParseObject("LevelCompletion");
		levelCompletion["UserID"] = userID;

		levelCompletion["level"] = level;

		levelCompletion ["log"] = log;

		levelCompletion["totalMoves"] = totalMoves	;

		levelCompletion.SaveAsync();



		var query = ParseObject.GetQuery("CurrentState")
			.WhereEqualTo("UserID", userID);
		query.FirstAsync().ContinueWith(t =>
		                                {
			ParseObject obj = t.Result;				
			obj["level"]=level;
			obj.SaveAsync();
			
		});

		PlayerPrefs.SetInt ("level", level);
		PlayerPrefs.Save();

	}

	public static int maxLevelCompleted(string userID){

//		int level=-1;
//		
//		var query = ParseObject.GetQuery("CurrentState")
//			.WhereEqualTo("UserID", userID);
//		query.FirstAsync().ContinueWith(t =>
//		                                {
//			ParseObject obj = t.Result;
//			if(obj!=null){
//
//				level= obj.Get<int>("level");
//			}
//			
//		});
//
//		Debug.Log ("max level query failed?"+ (level<0)+ " "+level);
		return 		PlayerPrefs.GetInt ("level", 1);


	}



}
