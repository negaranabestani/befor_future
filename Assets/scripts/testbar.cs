using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class testbar : MonoBehaviour {
	
	public GameObject player;
	public GameObject hand ;	
	public SpriteRenderer sphand;
	public Sprite meanpic;
	public bool triger=false;
	public bool free;
	public string entername;
	void Start () {
		
		
	}



	private void OnTriggerEnter2D ( Collider2D colcoin)
	{
		if (colcoin.name == "staphin") {
			sphand = hand.GetComponent<SpriteRenderer> ();
			if (free == true) {
				if (gameObject.name == "sss") {
						SceneManager.LoadScene ("l1s3");

					levelmanager.vgg="sss";
				}

			}
			else if (sphand.sprite == null) {
				print ("it is locked");
			}
			else if (sphand.sprite.name == meanpic.name&&sphand.sprite != null) {
				triger = true;
			}

		}


	}


	void Update () {
		
	}
}
