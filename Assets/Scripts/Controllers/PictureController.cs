using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Set the right picture whenever it's a match!
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

	public void HideMiniPhotos (){
		for (int i = 0; i < miniphotos.Length; i++){
			miniphotos [i].SetActive (false);
		}
	}
}
