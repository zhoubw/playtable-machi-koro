using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TouchScript.Gestures;

public class TapRNG : MonoBehaviour {
	public Text text;

	void OnEnable() {
		GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		GetComponent<TapGesture> ().Tapped -= TapHandler;
	}

	public void TapHandler(object sender, System.EventArgs e) {
		System.Random r = new System.Random();
		int n = r.Next (1, 7);
		text.text = n + "";
	}
}
