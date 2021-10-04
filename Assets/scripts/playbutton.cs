using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour {
	private testbar change;


	public void play (string scene)
	{
		//if(change.changescene()==false)
			SceneManager.LoadScene (scene);
	}

	public void start ()
	{
		change = GetComponent<testbar> ();
	}
}
