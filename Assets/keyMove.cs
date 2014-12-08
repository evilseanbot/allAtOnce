﻿using UnityEngine;
using System.Collections;

public class keyMove : MonoBehaviour {

	float x_pos = 0;
	float y_pos = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("up")) {
			y_pos -= 0.1f;
		}

		if (Input.GetKey ("down")) {
			y_pos += 0.1f;
		}

		if (Input.GetKey ("left")) {
			x_pos -= 0.1f;
		}

		if (Input.GetKey ("right")) {
			x_pos += 0.1f;
		}

		transform.localRotation = Quaternion.Euler (new Vector3 (y_pos, x_pos, 0));

		transform.FindChild ("Quad").localScale = new Vector3(0.01f * Mathf.Cos (y_pos/60),
		    0.01f,
		    0.01f);


	}

	void OnCollisionEnter() {
		Debug.Log ("Collide!");
	}
}
