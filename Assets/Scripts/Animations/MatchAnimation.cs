using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handle the "It's a Match" message animation.
/// </summary>

public class MatchAnimation : MonoBehaviour {

	/// <summary>
	/// GameObjects requires to ba activated and animated during the "It's a match" message.
	/// </summary>

	public GameObject background, text01, text02, picture, button01, button02;

	/// <summary>
	/// Constructor: Start "It's a Match" animation calling the Coroutine "StartAnimation ()".
	/// </summary>

	void OnEnable () {
		StartCoroutine (StartAnimation ());
	}

	/// <summary>
	/// Execute the animation using LeanTween to perform the animations.
	/// </summary>

	private IEnumerator StartAnimation (){
		LeanTween.alpha (background, 0.92f, 0.3f);
		yield return new WaitForSeconds (0.2f);
		picture.SetActive (true);
		LeanTween.scale (picture, new Vector2 (1.2f, 1.2f), 0.15f);
		yield return new WaitForSeconds (0.15f);
		LeanTween.scale (picture, new Vector2 (1f, 1f), 0.1f);
		yield return new WaitForSeconds (0.1f);
	}
}
