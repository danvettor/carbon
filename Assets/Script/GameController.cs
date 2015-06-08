using UnityEngine;
using System.Collections;

public class GameController: MonoBehaviour {
	private bool
		pressedButton;
	public GameObject Carbon;
	Vector3 temp;

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
		Vector3 temp2 = new Vector3 (Camera.main.ScreenPointToRay (position).origin.x, Camera.main.ScreenPointToRay (position).origin.y, 0);
		print ("Posiçao do carbono Screen to Viweport: " + Camera.main.ScreenToViewportPoint(position));
		print ("Posiçao do carbono World to Screen: " + Camera.main.WorldToScreenPoint(position));
		print ("Posiçao do carbono Screen to Ray: " + Camera.main.ScreenPointToRay(position));
		print ("Posiçao do carbono Viewport to World: " + Camera.main.ViewportToWorldPoint(position));
		//print ("Posiçao do carbono: " + Camera.main.ScreenToViewportPoint(position));
		Instantiate (Carbon, temp2, Quaternion.identity);
	}
}
