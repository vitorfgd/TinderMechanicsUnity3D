using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Open message and close everything else.
/// </summary>

public class MessageController : MonoBehaviour {

	public GameObject main, deck, messages;

	public void OpenMessages(){
		main.SetActive (false);
		deck.SetActive (false);
		messages.SetActive (true);
	}
}
