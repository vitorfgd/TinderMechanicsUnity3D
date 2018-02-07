using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Wait and set swipe active.
/// </summary>

public class CardBehaviorController : MonoBehaviour {

	/// <summary>
	/// Find the swipe controller script.
	/// </summary>

	private SwipeController swipeController;

	/// <summary>
	/// Constructor method will find the script and assign it to swipeController variable of SwipeController find. 
	/// It will also wait half a second before activating the swipe.
	/// </summary>

	void Start () {
		swipeController = this.gameObject.GetComponent <SwipeController> ();
		Invoke ("ActivateSwipe", 0.5f);
	}

	/// <summary>
	/// If the script was succesfully found, enable it.
	/// </summary>

	void ActivateSwipe (){
		if (swipeController != null){
			swipeController.enabled = true;
		}
	}
}
