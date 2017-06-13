﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	/// <summary>
	/// Main Menu Controller.
	/// This class handles user clicks on menu button, and also fetch and shows user saved scores on screen.
	/// </summary>
	
	private int bestScore;				
	private int lastScore;				

	public GameObject bestScoreText;	
	public GameObject lastScoreText; 

	public AudioClip menuTap;			
	
	private bool canTap;						
	private float buttonAnimationSpeed = 9.0f;	
	

	void Awake () {
		
		canTap = true; 
		
		bestScore = PlayerPrefs.GetInt("bestScore");
		bestScoreText.GetComponent<TextMesh>().text = bestScore.ToString();
		
		lastScore = PlayerPrefs.GetInt("lastScore");
		lastScoreText.GetComponent<TextMesh>().text = lastScore.ToString();
	}


	void Start() {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}


	void Update () {
		if(canTap)	
			StartCoroutine(tapManager());
	}
	
	
	
	private RaycastHit hitInfo;
	private Ray ray;
	IEnumerator tapManager() {

		if(	Input.touches.Length > 0 && Input.touches[0].phase == TouchPhase.Ended)  
			ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
		else if(Input.GetMouseButtonUp(0))
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		else
			yield break;
		
		if (Physics.Raycast(ray, out hitInfo)) {
			GameObject objectHit = hitInfo.transform.gameObject;
			switch(objectHit.name) {
			case "Btn-Mode-01":
					canTap = false;
					playSfx (menuTap);
					PlayerPrefs.SetInt ("GameMode", 0);
					StartCoroutine (animateButton (objectHit));
					yield return new WaitForSeconds (1.0f);
					SceneManager.LoadScene ("Game");
					break;

				case "Btn-Mode-02":
					canTap = false;
					playSfx(menuTap);
					PlayerPrefs.SetInt("GameMode", 1);
					StartCoroutine(animateButton(objectHit));
					yield return new WaitForSeconds(1.0f);
					SceneManager.LoadScene ("Game");
					break;
					
				case "btnExit":
					canTap = false;
					playSfx(menuTap);
					StartCoroutine(animateButton(objectHit));
					yield return new WaitForSeconds(1.0f);
					Application.Quit();
					break;
			}	
		}
	}
	

		IEnumerator animateButton(GameObject _btn) {

		Vector3 startingScale = _btn.transform.localScale;
		Vector3 destinationScale = startingScale * 1.1f;
		float t = 0.0f; 
		while (t <= 1.0f) {
			t += Time.deltaTime * buttonAnimationSpeed;
			_btn.transform.localScale = new Vector3(Mathf.SmoothStep(startingScale.x, destinationScale.x, t),
			                                        _btn.transform.localScale.y,
			                                        Mathf.SmoothStep(startingScale.z, destinationScale.z, t));
			yield return 0;
		}
		
		float r = 0.0f; 
		if(_btn.transform.localScale.x >= destinationScale.x) {
			while (r <= 1.0f) {
				r += Time.deltaTime * buttonAnimationSpeed;
				_btn.transform.localScale = new Vector3(Mathf.SmoothStep(destinationScale.x, startingScale.x, r),
				                                        _btn.transform.localScale.y,
				                                        Mathf.SmoothStep(destinationScale.z, startingScale.z, r));
				yield return 0;
			}
		}
		
		if(r >= 1)
			canTap = true;
	}
	
	void playSfx(AudioClip _sfx) {
		GetComponent<AudioSource>().clip = _sfx;
		if(!GetComponent<AudioSource>().isPlaying)
			GetComponent<AudioSource>().Play();
	}
}
