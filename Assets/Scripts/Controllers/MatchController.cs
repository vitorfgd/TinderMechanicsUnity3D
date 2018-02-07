using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will enable the "It's a Match" message.
/// </summary>

public class MatchController : MonoBehaviour {

	/// <summary>
	/// There is no need in enabling and disabling every component inside of the "It's a Match" message.
	/// This can be done by simply using its parent.
	/// </summary>

	public GameObject _matchGO;

	/// <summary>
	/// Enable the "It's a Match" message parent.
	/// </summary>
	
	public void ShowMatch (){
		_matchGO.SetActive (true);
	}
}
