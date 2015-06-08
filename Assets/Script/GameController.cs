using UnityEngine;
using System.Collections;

public class GameController: MonoBehaviour {
	private bool
		pressedButton;
	public GameObject Carbon;
	Vector3 temp;
	public Camera camera;

	void Start () {
		pressedButton = false;
	}
	void Update () {
		if (Input.GetMouseButton (0))
		{
			pressedButton = true;
			temp = Input.mousePosition;
		}	
		else
		{
			if (pressedButton == true)
			{
				print("Posiçao do mouse: " + temp);
				createCarbon(temp);
				pressedButton = false;
			}
		}
	}	
	void createCarbon(Vector3 position)
	{
		Vector3 temp2 = castRayToWorld(position);
		Instantiate (Carbon, temp2, Quaternion.identity);
	}

	Vector3 castRayToWorld(Vector3 mousePos) 
	{
		Ray ray = Camera.main.ScreenPointToRay(mousePos);    
		Vector3 point = ray.origin + (ray.direction * 5.0f);    
		Debug.Log("World point " + point);
		return point;
	}
}
