using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {

	public static string vgg;
	public GameObject bk;
	// Use this for initialization
	void Start () {
		//vgg="sss";
		if (vgg == "sss") {
			bk.transform.position += new Vector3 (0, -9.59f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
