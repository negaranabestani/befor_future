using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startarmeyview : MonoBehaviour
{
	bool x=false ;
	public void showview(GameObject pv)
	{
		if (x == false) {
			pv.SetActive (true);
			x = true;
		}
		else  {
			pv.SetActive (false);
			x = false;
		}
	}



}
