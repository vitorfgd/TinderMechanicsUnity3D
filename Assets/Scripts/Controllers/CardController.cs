using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CardController will be responsible for creating and managing the deck as the user is playing.
/// </summary>

public class CardController : MonoBehaviour {

	/// <summary>
	/// Stores every card option for the game.
	/// </summary>

	public GameObject [] cardPrefabs;

	/// <summary>
	/// Store the cards parent (in order to keep the hierarchy organized)
	/// </summary>
	
	public Transform deck;

	/// <summary>
	/// How many cards should the game start with.
	/// </summary>

	public int initialCards;

	/// <summary>
	/// Which card, from the available in the prefabs pool should be choosed.
	/// </summary>

	private int randomCardChoose;

	/// <summary>
	/// Controls how many cards are in the deck 
	/// </summary>

	private int totalCards;

	/// <summary>
	/// A list of each card in the deck and it's position, it's updated every swipe.
	/// </summary>
	/// <returns></returns>

	private List<GameObject> cardList = new List<GameObject>();

	/// <summary>
	/// A list of each character position in order to call the right It's a Match.
	/// </summary>
	/// <returns></returns>

	private List<int> characterPositions = new List <int> ();

	/// <summary>
	/// A list of each card swiped.
	/// </summary>
	/// <returns></returns>

	private List<int> cardsSwiped = new List <int> ();

	/// <summary>
	/// Control variable created to place new cards below the existing ones.
	/// </summary>

	private float depth;

	/// <summary>
	/// Constructor: will find game areas (main and messages), enable the correct area, assign key variables and initiate card instantiation.
	/// </summary>

	void Start () {
		totalCards = initialCards;
		StartCoroutine (CreateCards ());
	}

	/// <summary>
	/// Deck creation: this function will be called once and it will create a deck of X (given) from the card prefabs pool.
	/// </summary>
	/// <returns>A deck of card with given size.</returns>

	private IEnumerator CreateCards(){

		depth = -1f;

		for (int i = 0; i < initialCards; i++) {
			
			randomCardChoose = Random.Range (0, cardPrefabs.Length);

			depth -= 0.001f;
			GameObject cardClone = Instantiate (cardPrefabs [randomCardChoose], new Vector3 (0f, 8f, depth), Quaternion.AngleAxis (60f, Vector3.forward), deck);
			LeanTween.rotateZ (cardClone, 0f, 0.1f);
			LeanTween.move (cardClone, new Vector3 (0f, 0f, depth), 0.1f);
		
			characterPositions.Add (randomCardChoose);
			cardList.Add (cardClone);

			yield return new WaitForSeconds (0.1f);
		}
	}

	/// <summary>
	/// Function created to call the private coroutine "CreateCards" whenever there are no cards left.
	/// </summary>

	public void CreateMoreCards (){
		StartCoroutine (CreateCards ());
	}

	/// <summary>
	/// Return how many cards were swiped to check which character is currently active to be used in case of a match.
	/// </summary>
	/// <returns></returns>

	public int ReturnCurrentPosisitionAndCharacter (){
		return cardsSwiped [cardsSwiped.Count - 1];
	}

	/// <summary>
	/// In case of swipe left, remove the card.
	/// </summary>

	public void RemoveCardsAndCheckTotal (){

		int number = characterPositions[totalCards - 1];
		cardsSwiped.Add (number);

		characterPositions.RemoveAt (totalCards - 1);
		cardList.RemoveAt (totalCards - 1);
		totalCards--;

		if (totalCards <= 0){
			totalCards = initialCards;
			CreateMoreCards ();
		}
	}
}
