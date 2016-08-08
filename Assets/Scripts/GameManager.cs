using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject cardManagerObject;
	public CardManager cardManager;

	public Vector2 startingPosition = new Vector2 (-4.8f, 2.43f);
	public Vector2 currentPosition = new Vector2 (-4.8f, 2.43f);
	public float dX = 1.69f;
	public float dY = -2.16f;
	public int decksInRow = 7;
	public int decks = 0;

	void Start () {
		Camera.main.transparencySortMode = TransparencySortMode.Orthographic;
		cardManager = cardManagerObject.GetComponent<CardManager> ();
		initialize ();
	}

	public void initialize() {
		//flower field
		//Deck flowerFields = ((GameObject) cardManager.createDeck(currentPosition)).GetComponent<Deck>();
		//createCards (flowerFields, 1, 15, 6);
		//flowerFields.flip ();
		//adjustPosition ();
		for (int i = 1; i <= 6; i++) {
			createPile (i, 16, 6);
		}
		createPile (7, 16, 5);
		createPile (8, 16, 6);
		createPile (9, 16, 6);
		createPile (10, 16, 5);
		//createPile (25, 16, 5);
		//createPile (26, 16, 6);
		//createPile (27, 16, 6);
		createPile (28, 16, 4);
		createPile (29, 16, 4);
		createPile (30, 16, 4);

		createPile (26, 15, 50);
		createPile (27, 15, 50);
		createPile (11, 12, 50);
		createPile (13, 14, 50);
		for (int i = 17; i < 23; i += 2) {
			createPile (i, i + 1, 50);
		}
		createPile (25, 15, 50);

		//Deck makeralFishingBoats = ((GameObject)cardManager.createDeck (currentPosition)).GetComponent<Deck> ();
		//createCards (makeralFishingBoats, 2, 15, 6);
		//adjustPosition ();
	}

	public void createPile(int front, int back, int num) {
		Deck d = ((GameObject) cardManager.createDeck(currentPosition)).GetComponent<Deck>();
		createCards (d, front, back, num);
		d.flip ();
		adjustPosition ();
	}

	public void createCards(Deck deck, int front, int back, int num) {
		for (int i = 0; i < num; i++) {
			GameObject card = deck.createCard ();
			string fStr = front + "";
			if (front <= 1) {
				fStr = "";
			}
			string bStr = back + "";
			if (back <= 1) {
				bStr = "";
			}
			Sprite b = Resources.Load<Sprite> ("cardSprites/machi koro expansion" + bStr);
			card.GetComponent<Card> ().setSpriteBack (b);
			Sprite f = Resources.Load<Sprite> ("cardSprites/machi koro expansion" + fStr);
			card.GetComponent<Card> ().setSpriteFront (f);
		}
	}

	public void adjustPosition() {
		currentPosition.x += dX;
		decks += 1;
		if (decks == decksInRow) {
			decks = 0;
			currentPosition.x = startingPosition.x;
			currentPosition.y += dY;
		}
	}
}
