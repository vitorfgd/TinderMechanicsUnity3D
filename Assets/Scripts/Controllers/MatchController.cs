using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In case of match, set match to active.
/// </summary>

public class MatchController : MonoBehaviour {

	public GameObject _matchGO;
	
	public void ShowMatch (){
		_matchGO.SetActive (true);
	}
}
