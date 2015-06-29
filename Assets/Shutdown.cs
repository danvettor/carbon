using UnityEngine;
using System.Collections;

public class Shutdown : MonoBehaviour {

	public GameObject quitPopup;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void shutdown() {
		quitPopup.SetActive (true);
	}
}
