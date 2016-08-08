using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TouchScript.Gestures;

public class TapAddPlayer : MonoBehaviour {
	public GameObject pocketPrefab;

	void OnEnable() {
		GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		GetComponent<TapGesture> ().Tapped -= TapHandler;
	}

	public void TapHandler(object sender, System.EventArgs e) {
		Instantiate (pocketPrefab, pocketPrefab.transform.position, pocketPrefab.transform.rotation);
	}
}
