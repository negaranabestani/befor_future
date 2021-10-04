using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundsound : MonoBehaviour {

	// Use this for initialization
	public AudioClip bsound;
	private AudioSource bmusic;

	void Start () {
		bmusic = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		bmusic.PlayOneShot(bsound,0.01f);
		
	}
}
