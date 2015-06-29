using UnityEngine;
using System.Collections;

public class RotateStructures : MonoBehaviour {
	public Camera camera;
	public GameObject[] molecularStructure;
	public float rotationSpeed;
	private GameObject currentStructure;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject structure in molecularStructure) {
			if(structure.activeInHierarchy) {
				currentStructure = structure;
			}

		}

		if (currentStructure == null) {
			Debug.Log("deu eruim"); 
			return;
		}

		if (Input.GetMouseButton(0)) {
			currentStructure.transform.Rotate(new Vector3(0.0f, -1*Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")), rotationSpeed);
		}
	}
}
