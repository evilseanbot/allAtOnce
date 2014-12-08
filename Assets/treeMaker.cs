using UnityEngine;
using System.Collections;

public class treeMaker : MonoBehaviour {

	public GameObject tree;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 360 * 2; i++) {
			GameObject myTree = (GameObject)Instantiate (tree);
			projectToSphere pts = myTree.GetComponent<projectToSphere>();
			pts.x_pos = Random.Range (-180, 180);
			pts.y_pos = Random.Range (-90, 90);
			pts.project();

		}
			                                                            

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
