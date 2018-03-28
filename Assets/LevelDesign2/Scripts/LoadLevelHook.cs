using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelHook : MonoBehaviour {

	public void LoadLevel(int ID){
		SceneManager.LoadScene (ID);
	}

	public void LoadLevel(string name){
		SceneManager.LoadScene (name);
	}

	public void ExitGame(){
		Application.Quit ();
	}

}
