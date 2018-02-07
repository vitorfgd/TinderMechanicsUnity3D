using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class destroys cards after swipe on both directions. There are no constructions.
/// This script is attached to the card.
/// </summary>

public class CardDestroyerBehavior : MonoBehaviour {

	/// <summary>
	/// Check every frame end if a card position in the x axis is greater than 48 or less than -48, if it is, destroy the card.
	/// </summary>

	void Update () {
		if (this.gameObject.transform.position.x > 0){
			if (this.gameObject.transform.position.x >= 48){
				Destroy (this.gameObject);
			}
		}

		if (this.gameObject.transform.position.x < 0){
			if (this.gameObject.transform.position.x <= -48){
				Destroy (this.gameObject);
			}
		}
	}
}
