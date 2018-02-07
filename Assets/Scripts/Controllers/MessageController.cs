using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will handle the change between the main and the message area of the game.
/// </summary>

public class MessageController : MonoBehaviour {

	/// <summary>
	/// This objects are needed for the main to message area change.
	/// </summary>

	public GameObject main, deck, messages;

	/// <summary>
	/// Disable both the main area and the cards. Without destroying it.
	/// </summary>

	public void OpenMessages(){
		main.SetActive (false);
		deck.SetActive (false);
		messages.SetActive (true);
	}
}
