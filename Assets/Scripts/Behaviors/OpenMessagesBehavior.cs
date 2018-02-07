using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In case of "Send message" is clicked. Open message area.
/// </summary>

public class OpenMessagesBehavior : MonoBehaviour {

	/// <summary>
	/// Find the MessageController script.
	/// </summary>

	private MessageController messageController;

	/// <summary>
	/// On "Send Message", call the method OpenMessages from MessageController.
	/// </summary>

	void OnMouseDown (){
		messageController = FindObjectOfType (typeof (MessageController)) as MessageController;
		messageController.OpenMessages ();
	}
}
