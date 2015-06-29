using UnityEngine;
using System.Collections;

public class HidePopup : MonoBehaviour {

	public GameObject popup;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hide() {
		popup.SetActive (false);
	}
}
