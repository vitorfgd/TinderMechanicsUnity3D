using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles a click on the "Send Message" button in the "It's a Match" message.
/// </summary>

public class OpenMessagesBehavior : MonoBehaviour {

	/// <summary>
	/// The messageController variable will be needed to call a method from MessageController script.
	/// </summary>

	private MessageController messageController;

	/// <summary>
	/// OuMouseDown handles the click on "Send Message" during the "It's a Match!" message.
	/// This script will find MessageController, assign it to messageController, call the method "OpenMessages ()" using a reference to the script assigned previously 
	/// which will then disable the main area and enable the message area of the game.
	/// </summary>

	void OnMouseDown (){
		messageController = FindObjectOfType (typeof (MessageController)) as MessageController;
		messageController.OpenMessages ();
	}
}
