using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchAnimation : MonoBehaviour {

	/// <summary>
	/// Activate and animate every element in the "It's a match" message.
	/// </summary>

	public GameObject background, text01, text02, picture, button01, button02;

	/// <summary>
	/// Constructor: Start "It's a match" animation.
	/// </summary>

	void OnEnable () {
		StartCoroutine (StartAnimation ());
	}

	/// <summary>
	/// It's a match animation done with LeanTween.
	/// </summary>
	/// <returns></returns>

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
