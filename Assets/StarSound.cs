using UnityEngine;
using System.Collections;

public class StarSound : MonoBehaviour {

	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void CoinSound (){
		audioSource.Play();
	}
	
}
