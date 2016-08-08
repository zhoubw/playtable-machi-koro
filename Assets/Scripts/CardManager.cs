/*
 * GameManager.cs
 * 
 * The main handler of cards and decks.
 * 
 */

using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour {

	public GameObject deckPrefab;
	public GameObject cardPrefab;

    /*
	void Awake() {
		// Example of creating a deck of 52 cards at (0, 0)
		// GameObject newDeck = createDeck (0, 0);
		// for (int i = 0; i < 52; i++) {
		//	newDeck.GetComponent<Deck> ().createCard ();
		//}
	}
    */

	public GameObject createDeck(Vector2 pos) {
		return (GameObject) Instantiate (deckPrefab, new Vector3 (pos.x, pos.y, deckPrefab.transform.position.z), deckPrefab.transform.rotation);
	}

	public GameObject createDeck(float x, float y) {
		Vector2 pos = new Vector2 (x, y);
		return createDeck (pos);
	}

	public GameObject createCard(Vector2 pos) {
		return (GameObject)Instantiate (cardPrefab, new Vector3 (pos.x, pos.y, cardPrefab.transform.position.z), cardPrefab.transform.rotation);
	}

	public GameObject createCard(float x, float y) {
		Vector2 pos = new Vector2 (x, y);
		return createCard (pos);
	}
}
