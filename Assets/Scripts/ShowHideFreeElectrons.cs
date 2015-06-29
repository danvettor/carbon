using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class ShowHideFreeElectrons : MonoBehaviour {

	private bool isVisible = true;
	private ArrayList freeElectronGameObjects;

	void Start () {
		freeElectronGameObjects = new ArrayList();
	}

	void Update () {
		GameObject[] freeElectron = GameObject.FindGameObjectsWithTag("FreeElectron");

		foreach (GameObject go in freeElectron) {
			if (!freeElectronGameObjects.Contains(go)) {
				freeElectronGameObjects.Add(go);
				go.SetActive(isVisible);
			}
		}
	}

	public void showHideElectrons () {
		isVisible = !isVisible;

		foreach (GameObject go in freeElectronGameObjects) {
			go.SetActive(isVisible);
		}
	}
}
