﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaoChet : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collision)
	{		
		if (collision.gameObject.tag == "Player") {
			Application.LoadLevel("gameover");
		}
	}
	void OnTriggerEnter2D(Collider2D trigger){
		if (trigger.gameObject.tag=="Ga") {
			Destroy (trigger.gameObject);
		}
	}
}
