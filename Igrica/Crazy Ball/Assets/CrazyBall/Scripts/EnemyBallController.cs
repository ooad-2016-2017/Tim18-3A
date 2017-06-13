using UnityEngine;
using System.Collections;

public class EnemyBallController : MonoBehaviour {

	/// <summary>
	/// This class moves enemyballs in survival mode to the bottom of the screen.
	/// The game is over if any enemyball reach to the botttom.
	/// </summary>
	
	private float speed;							
	private float destroyThreshold = -6.5f;			
    	
	void Start() {
		speed = Random.Range(0.6f, 2.0f);
	}

	void Update() {
		transform.position -= new Vector3(0, 0, Time.deltaTime * 
		                                 		GameController.moveSpeed * 
		                                 		speed);
		
		if (transform.position.z < destroyThreshold) {
			GameController.gameOver = true;
			Destroy(gameObject);
		}
	}
}
