using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	/// <summary>
	/// Main Player manager class.
	/// We check all player collisions here.
	/// We also calculate the score in this class. 
	/// </summary>
	
	public static int playerScore;			
	public GameObject scoreTextDynamic;		


	void Awake() {
		playerScore = 0;			
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Application.targetFrameRate = 60;
	}
	
	
	void Update() {
		if(!GameController.gameOver)
			calculateScore();
	}
	
	
	
	void calculateScore() {
		if(!PauseManager.isPaused) {
			playerScore += (int)( GameController.currentLevel * Mathf.Log(GameController.currentLevel + 1, 2) );
			scoreTextDynamic.GetComponent<TextMesh>().text = playerScore.ToString();
		}
	}


	
	void OnCollisionEnter(Collision c) {

		

		if(c.gameObject.tag == "Maze") {
			print ("Game Over");
			GameController.gameOver = true;
		}

		if(c.gameObject.tag == "enemyBall") {
			Destroy(c.gameObject);
		}
	}
	
	
	void playSfx(AudioClip _sfx) {
		GetComponent<AudioSource>().clip = _sfx;
		if(!GetComponent<AudioSource>().isPlaying)
			GetComponent<AudioSource>().Play();
	}
}
