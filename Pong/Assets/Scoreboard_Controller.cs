using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_Controller : MonoBehaviour {

	public static Scoreboard_Controller instance;

	public Text playerOneScoreText;
	public Text playerTwoScoreText;

	public int playerOneScore;
	public int playerTwoScore;

	
	void Start () {

		instance = this;

		playerOneScore = playerTwoScore = 0;
	}
	
	
	void Update () {

		
	}

	public void GivePlayerOneAPoint () {

		playerOneScore += 1;

		playerOneScoreText.text = playerOneScore.ToString ();

		
		if (playerOneScore > 10) {

			SceneManager.LoadScene (2);
		}
	}

	public void GivePlayerTwoAPoint () {

		playerTwoScore += 1;

		playerTwoScoreText.text = playerTwoScore.ToString ();

		
		if (playerTwoScore > 10) {

			SceneManager.LoadScene (3);
		}
	}

}
