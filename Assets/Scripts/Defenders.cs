﻿using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D () {
		Debug.Log (name + " triger enter");
	}
}

