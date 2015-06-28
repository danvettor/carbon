using UnityEngine;
using System.Collections;

public class RotateStructures : MonoBehaviour {
	public GameObject[] molecularStructure;
	public float rotationSpeed;
	private GameObject currentStructure;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject structure in molecularStructure) {
			if(structure.activeInHierarchy)
			{
				currentStructure = structure;
			}

		}
		if (Input.GetMouseButton (0)) {
			currentStructure.transform.Rotate(Input.mousePosition*Time.deltaTime*rotationSpeed);
		}
		else currentStructure.transform.Rotate (Vector3.right*Time.deltaTime*rotationSpeed);
	
	}
}
