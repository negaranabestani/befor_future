using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
public class lamp : MonoBehaviour {
	public Sprite prefab;
    SpriteRenderer sphand;
	public GameObject hand;
	public GameObject mean;
	private Light lights;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		sphand=hand.GetComponent<SpriteRenderer>();
		lights = hand.GetComponent<Light> ();
		print("gg"+usebar.handisoff);
		if (sphand.sprite == prefab&& mean!= null&&usebar.handisoff==false) {


			mean.SetActive (true);

		}
		else if(usebar.handisoff==true&& mean!=null)
			mean.SetActive (false);
		
		if (sphand.sprite == prefab) {
			lights.enabled = true;
		}
		else if(sphand.sprite!=prefab){

			lights.enabled = false;
		}

	}
}
