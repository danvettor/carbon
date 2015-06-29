using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class RotateStructures : MonoBehaviour, IDragHandler {
	public Camera camera;
	public GameObject[] molecularStructure;
	public float rotationSpeed;
	private GameObject currentStructure;

	public void OnDrag(PointerEventData data) {
		foreach (GameObject structure in molecularStructure) {
			if(structure.activeInHierarchy) {
				currentStructure = structure;
			}
			
		}
		
		if (currentStructure == null) {
			return;
		}
		
		if (Input.GetMouseButton(0)) {
			currentStructure.transform.Rotate(new Vector3(0.0f, -1*Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")), rotationSpeed);
		}
	}
}
