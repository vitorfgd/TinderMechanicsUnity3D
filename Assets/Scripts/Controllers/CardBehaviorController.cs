using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for handleing the Behavior of a card.
/// </summary>

public class CardBehaviorController : MonoBehaviour {

	/// <summary>
	/// The swipeController variable will be needed to call a method from the SwipeController script.
	/// </summary>

	private SwipeController swipeController;

	/// <summary>
	/// Constructor method is responsible for getting the script SwipeController and assign it to swipeController variable. 
	/// It will also Invoke the method "ActivateSwipe ()" after half a second.
	/// </summary>

	void Start () {
		swipeController = this.gameObject.GetComponent <SwipeController> ();
		Invoke ("ActivateSwipe", 0.5f);
	}

	/// <summary>
	/// If swipeControll is different then null it means that the script was found during the Constructor assignment.
	/// If that is the case, enable the swipeController script on the gameObject. Due to Invoke, this will happen 0.5 seconds after the game start.
	/// </summary>

	void ActivateSwipe (){
		if (swipeController != null){
			swipeController.enabled = true;
		}
	}
}
