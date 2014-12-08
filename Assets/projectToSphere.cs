using UnityEngine;
using System.Collections;

public class projectToSphere : MonoBehaviour {
	
	public float x_pos = 0;
	public float y_pos = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void project() {
		transform.localRotation = Quaternion.Euler (new Vector3 (y_pos, x_pos, 0));	
		transform.FindChild ("Quad").localScale = new Vector3(0.01f * Mathf.Cos (y_pos/60),
			0.01f,
		    0.01f);
	}
}
