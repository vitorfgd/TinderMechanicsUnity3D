using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles a click on the "Keep Scrolling" button in the "It's a Match" message.
/// </summary>

public class HideMatch : MonoBehaviour {

	/// <summary>
	/// Match content, there is no need to disable each component inside of "match" so it's easier to just disable the parent.
	/// </summary>

	public GameObject match;

	/// <summary>
	/// The pictureController variable will be needed to call a method from PictureController script.
	/// </summary>

	private PictureController pictureController;

	/// <summary>
	/// OuMouseDown handles the click on "Keep Scrolling" during the "It's a Match!" message.
	/// This script will find PictureController, assign it to pictureController, disable the picture using a reference to the script assigned previously 
	/// and set the match (parent of each component in the "It's a Match!" message) to false.
	/// </summary>

	void OnMouseDown (){
		pictureController = FindObjectOfType (typeof (PictureController)) as PictureController;
		pictureController.HideMiniPhotos ();
		match.SetActive (false);
	}
}
