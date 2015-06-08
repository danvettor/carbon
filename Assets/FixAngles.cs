using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FixAngles : MonoBehaviour {
	
	void Start () {
		List<Vector3> links = new List<Vector3>();
		foreach (Transform child in gameObject.transform) {
			links.Add(child.position - this.transform.position);
		}

		int childCount = gameObject.transform.childCount;
		for (int i = 0; i < childCount; ++i) {
			Transform child = this.transform.GetChild(i);
			Transform nextChild = this.transform.GetChild((i + 1)%childCount);
			Vector3 childLink = child.position - this.transform.position;
			Vector3 nextChildLink = nextChild.position - this.transform.position;
			float cosBetweenLinks = Vector3.Dot(childLink, nextChildLink)/(childLink.magnitude*nextChildLink.magnitude);
			float angleBetweenLinks = Mathf.Rad2Deg*Mathf.Acos(cosBetweenLinks);
			Debug.Log("CHILD NAME: " + child.name);
			Debug.Log("NEXT CHILD NAME: " + nextChild.name);
			Debug.Log("ANGLE BETWEEN LINKS: " + angleBetweenLinks);
			float angleToTurn = getAngleBetweenAtoms(childCount) - angleBetweenLinks;
			Debug.Log("ANGLE TO TURN: " + angleToTurn);
			nextChild.transform.RotateAround(this.transform.position, this.transform.forward, angleToTurn);
		}

		for (int i = 0; i < childCount; ++i) {
			Transform child = this.transform.GetChild(i);
			Transform nextChild = this.transform.GetChild((i + 1)%childCount);
			Vector3 childLink = child.position - this.transform.position;
			Vector3 nextChildLink = nextChild.position - this.transform.position;
			float cosBetweenLinks = Vector3.Dot(childLink, nextChildLink)/(childLink.magnitude*nextChildLink.magnitude);
			float angleBetweenLinks = Mathf.Rad2Deg*Mathf.Acos(cosBetweenLinks);
			Debug.Log("[AGAIN] ANGLE BETWEEN LINKS: " + angleBetweenLinks);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	float getAngleBetweenAtoms(int numberOfAtoms) {
		return 360.0f/numberOfAtoms;
	}
}
