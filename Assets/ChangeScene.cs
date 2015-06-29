using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		mouseInput ();
	}

	void mouseInput()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel("MainScene");
			
		}

	}
}
