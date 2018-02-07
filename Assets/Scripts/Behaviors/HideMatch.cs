using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In case of keep scrolling, hide the "It's a match" message;
/// </summary>

public class HideMatch : MonoBehaviour {

	/// <summary>
	/// Match content
	/// </summary>

	public GameObject match;

	/// <summary>
	/// Find the script pictureController to hide the picture.
	/// </summary>

	private PictureController pictureController;

	/// <summary>
	/// When click on keep scrolling this script will find PictureController, disable the picture and set the match to false.
	/// </summary>

	void OnMouseDown (){
		pictureController = FindObjectOfType (typeof (PictureController)) as PictureController;
		pictureController.HideMiniPhotos ();
		match.SetActive (false);
	}
}
