using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("New Level Load:" + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(string name){
		Debug.Log ("Quit Loaded Level:");
		Application.Quit();
	}

}
