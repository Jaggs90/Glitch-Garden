using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
	
	public float levelSeconds = 100f;
	
	private Slider slider;
	private AudioSource audioSource;
	private bool isEndOfLevel = false;
	private LevelManager levelmanager;
	private GameObject winLable;
	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		FindYouWin ();
		winLable.SetActive(false);
	}

	void FindYouWin ()
	{
		winLable = GameObject.Find ("Win");
		if (!winLable) {
			Debug.LogWarning ("create win object");
		}
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		
		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if (timeIsUp && !isEndOfLevel) {
			audioSource.Play();
			winLable.SetActive(true);
			Invoke ("LoadNextLevel", audioSource.clip.length);	
			isEndOfLevel = true;
		
		}
	}
	
	void LoadNextLevel (){
		levelmanager.LoadNextLevel();
	}
}
