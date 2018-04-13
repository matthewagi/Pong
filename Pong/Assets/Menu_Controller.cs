using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Controller : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

	public void StartGame () {

		SceneManager.LoadScene (1);
	}

	public void QuitGame () {

		Application.Quit ();
	}

}
