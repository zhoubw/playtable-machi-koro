using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TouchScript.Gestures;

public class TapAdd : MonoBehaviour {
	public Pocket pocket;

	void OnEnable() {
		GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		GetComponent<TapGesture> ().Tapped -= TapHandler;
	}

	public void TapHandler(object sender, System.EventArgs e) {
		pocket.add ();
	}
}
