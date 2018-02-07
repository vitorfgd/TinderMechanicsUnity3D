using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the swipe.
/// </summary>

[RequireComponent(typeof(BoxCollider))]
public class SwipeController : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 curPosition;

	private int random;

	private CardController cardController;
	private MatchController matchController;

	/// <summary>
	/// Constructor method will find CardController and MatchController scripts.
	/// </summary>

	// Use this for initialization
	void Start () {
		cardController = FindObjectOfType (typeof (CardController)) as CardController;
		matchController = FindObjectOfType (typeof (MatchController)) as MatchController;
	}
	
	/// <summary>
	/// Update method, called each frame end will rotate the picture based on it's position to give a cool sliding effect.!--
	/// It will also see if the card is within a range.
	/// </summary>


	// Update is called once per frame
	void Update () {
		LeanTween.rotate (this.gameObject, new Vector3 (0f, 0f, this.gameObject.transform.position.x * -2.5f), 0.0001f);
		transform.position = new Vector3 (this.gameObject.transform.position.x, Mathf.Clamp (this.gameObject.transform.position.y, 0f, 0f), this.gameObject.transform.position.z);
	}

	void OnMouseDown () {
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	/// <summary>
	/// On mouse up check if the card is between the two triggers, if it's not return the card to the pile, it is to the right, check if it's a match, if it is to the left, discard it.
	/// </summary>

	void OnMouseUp () {
		if (curPosition.x > 0){
			if (curPosition.x > 5f) {

				cardController.RemoveCardsAndCheckTotal ();
				LeanTween.move (this.gameObject, new Vector2 (50f, 0f), 0.5f);
				random = Random.Range (0, 10);

				if (random == 1 || random == 2 || random == 3){
					if (matchController != null) {
						matchController.ShowMatch ();
					}
				}
			} else {
				LeanTween.move (this.gameObject, Vector2.zero, 0.2f);
			}
		}

		if (curPosition.x < 0){
			if (curPosition.x < -5f) {
				cardController.RemoveCardsAndCheckTotal ();
				LeanTween.move (this.gameObject, new Vector2 (-50f, 0f), 0.5f);
			} else {
				LeanTween.move (this.gameObject, Vector2.zero, 0.2f);
			}
		}
	}

	/// <summary>
	/// On drag, drag the card with the cursor.
	/// </summary>

	void OnMouseDrag () {
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}
}
