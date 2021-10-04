using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Parallax scrolling script that should be assigned to a layer
/// </summary>
public class ScrollingScript : MonoBehaviour
{
	public controller cntrl;
	public GameObject liptush;
	public GameObject boundr;
	public GameObject player;
    Vector2 speed = new Vector2(1/100, 1/100);
    Vector2 direction = new Vector2(-1, 0);
	public bool isLinkedToCamera = false;
	public bool isLooping = false;
	private List<SpriteRenderer> backgroundPart;
	Animator staphinanim;
	Vector3 staphinscale;
	// 3 - Get all the children
	void Start()
	{
		cntrl = player.GetComponent<controller> ();
		staphinanim = player.GetComponent<Animator> ();
		cntrl.enabled = false;
		staphinscale = player.transform.localScale;
		// For infinite background only
		if (isLooping)
		{
			
			// Get all the children of the layer with a renderer
			backgroundPart = new List<SpriteRenderer>();


			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				SpriteRenderer r = child.GetComponent<SpriteRenderer>();

				// Add only the visible children
				if (r != null)
				{
					backgroundPart.Add(r);
				}
			}

			// Sort by position.
			// Note: Get the children from left to right.
			// We would need to add a few conditions to handle
			// all the possible scrolling directions.
			backgroundPart = backgroundPart.OrderBy(
				t => t.transform.position.x
			).ToList();
		}
	}

	void Update()
	{
		// Movement
		Vector3 movement = new Vector3(
			speed.x * direction.x,
			speed.y * direction.y,
			0);
		if (Input.GetKey (KeyCode.RightArrow)) {
			cntrl.enabled = false;
			movement *= Time.deltaTime;
			transform.Translate (movement / 10);
			staphinanim.SetInteger ("state", 2);
			player.transform.localScale = new Vector2 (staphinscale.x, staphinscale.y);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			cntrl.enabled = false;
			movement *= Time.deltaTime;
			transform.Translate (-movement / 10);
			staphinanim.SetInteger ("state", 2);
			player.transform.localScale = new Vector2 (-staphinscale.x, staphinscale.y);
		} 
		else {
			cntrl.enabled = true;
		}
			

		// Move the camera
		if (isLinkedToCamera)
		{
			Camera.main.transform.Translate(movement);
		}


		// 4 - Loop
		if (isLooping)
		{
			// Get the first object.
			// The list is ordered from left (x position) to right.
			SpriteRenderer firstChild = backgroundPart.FirstOrDefault();

			if (firstChild != null)
			{
				// Check if the child is already (partly) before the camera.
				// We test the position first because the IsVisibleFrom
				// method is a bit heavier to execute.
				if (firstChild.transform.position.x < Camera.main.transform.position.x)
				{
					// If the child is already on the left of the camera,
					// we test if it's completely outside and needs to be
					// recycled.
					//if (firstChild.IsVisibleFrom (Camera.main) == false) {
						// Get the last child position.
						SpriteRenderer lastChild = backgroundPart.LastOrDefault ();

						Vector3 lastPosition = lastChild.transform.position;
						Vector3 lastSize = (lastChild.bounds.max - lastChild.bounds.min);

						// Set the position of the recyled one to be AFTER
						// the last child.
						// Note: Only work for horizontal scrolling currently.
						//firstChild.transform.position = new Vector3(lastPosition.x + lastSize.x, firstChild.transform.position.y, firstChild.transform.position.z);

						// Set the recycled child to the last position
						// of the backgroundPart list.
						//backgroundPart.Remove(firstChild);
						//backgroundPart.Add(firstChild);
					//}
						if ( Input.GetKey (KeyCode.RightArrow)) {
							if (lastChild.IsVisibleFrom (Camera.main) == true) {
								speed = new Vector2 (0, 0);
								cntrl.enabled = true;
							}
							
							else	
								speed = new Vector2 (30, 30);
							


						}
					
						 if (Input.GetKey(KeyCode.LeftArrow)) {
						if (firstChild.IsVisibleFrom (Camera.main) == true) {
							speed = new Vector2 (0, 0);
							cntrl.enabled = true;

						}
							else	
							speed = new Vector2 (30, 30);

						}
							
					
				}
			}
		}
	}
}