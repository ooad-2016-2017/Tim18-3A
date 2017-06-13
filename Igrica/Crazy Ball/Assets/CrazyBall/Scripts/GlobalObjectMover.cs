using UnityEngine;
using System.Collections;

public class GlobalObjectMover : MonoBehaviour {

	/// <summary>
	/// This class moves the mazes down and destroys them when they pass a certain threshold
	/// </summary>

	[Range(1.5f, 2.5f)]
	public float speed = 2.0f;					
	private float destroyThreshold = -10.0f;	


	void Update() {
		transform.position -= new Vector3(0, 0, Time.deltaTime * GameController.moveSpeed * speed);
		
		if (transform.position.z < destroyThreshold) 
			Destroy(gameObject);
	}
}
