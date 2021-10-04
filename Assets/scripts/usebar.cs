using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;



public class usebar : MonoBehaviour {
	//public Sprite prefab;
    public SpriteRenderer sphand;
    public GameObject hand;
	public static bool handisoff=false;
	getcoin getthings;
	bool selected=true;
	public GameObject staphin;
	public static  int  flagg=1;
	public bool ismerging;
	static int selectedcountm=0;
	public int numberserlected=0;
	merege mrg;
	Transform worker;
	GameObject pworker;
	Transform tworker;
	bool check=false;
	bool homecheck=false;
	testbar tstworker;

	int on=0;
	void Start ()
	{
		mrg = GetComponent<merege> ();
		getthings = GetComponent<getcoin> ();
		gameObject.GetComponent<Button> ().onClick.AddListener(OnButtonClick);
	}
	public void OnButtonClick()
	{
		controller.state = 2;

		if (ismerging == false) {
			sphand.sprite = gameObject.GetComponent<Image> ().sprite;
			hand.transform.localScale = new Vector2 (1, 1);
			on++;
		}
		if (on == 1) {
			hand.SetActive (true);
			handisoff = false;
		}
		if (on == 2) {
			hand.SetActive (false);
			handisoff = true;
			on = 0;
		}

		if (ismerging == true && selected == true) {
			selectedcountm++;
			numberserlected = selectedcountm;
			selected = false;
		}
		if (sphand.sprite.name.Equals ("Tir&Kaman")) {
			pworker = GameObject.Find ("rocks_2 (2)");
			worker = pworker.transform.FindChild ("slingshot");
			tworker = pworker.transform.FindChild ("Prop_5 (2)");
			worker.gameObject.SetActive (true);
			tworker.gameObject.SetActive (true);
			hand.SetActive(false);
		} 

		/*else 
		  worker.gameObject.SetActive (false);*/
		
		if (sphand.sprite.name.Equals("keyhomeliptoos 1")) {
		    check=true;
			pworker = GameObject.Find ("rocks_2 (2)");
			worker = pworker.transform.FindChild ("liptooshome");
			tstworker = worker.GetComponent<testbar> ();


		}





		if (sphand.sprite.name.Equals("Gold_21")) {
			homecheck = true;
			pworker = GameObject.Find ("home");
			worker = pworker.transform.FindChild ("door");
			tstworker = worker.GetComponent<testbar> ();

			print (pworker.name);

		}


	
	}


	void  Update (){


		if (check == true) {
			if(tstworker.triger==true)
				SceneManager.LoadScene ("l1s3");
		}
		if (homecheck == true) {
			if(tstworker.triger==true)
				SceneManager.LoadScene ("l1s2");
		}

		if (ismerging == true) {
			mrg.enabled = true;
		}
		else
			mrg.enabled = false;
		
			
			
	}
	public void slingshot(){
		
	}

}
