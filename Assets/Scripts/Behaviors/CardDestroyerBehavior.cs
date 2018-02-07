using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroy card after swipe, doesn't matter to which direction..
/// </summary>

public class CardDestroyerBehavior : MonoBehaviour {

	/// <summary>
	/// If card position in x axis is greater than 48 or less than -48, destroy card.
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
