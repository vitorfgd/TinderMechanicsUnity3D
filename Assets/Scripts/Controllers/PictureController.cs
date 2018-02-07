using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for setting the right picture whenever there is a match!
/// </summary>

public class PictureController : MonoBehaviour {

	public GameObject[] miniphotos;

	private CardController cardController;

	/// <summary>
	/// Contructor method will find the CardController script, get the current character from it and set it to active.
	/// </summary>

	void OnEnable (){
		cardController = FindObjectOfType (typeof (CardController)) as CardController;
		int current_character = cardController.ReturnCurrentPosisitionAndCharacter ();
		miniphotos [current_character].SetActive (true);
	}

	/// <summary>
	/// This method will hide the pictures in case of keep scrolling or send message button pressing.
	/// </summary>

	public void HideMiniPhotos (){
		for (int i = 0; i < miniphotos.Length; i++){
			miniphotos [i].SetActive (false);
		}
	}
}
