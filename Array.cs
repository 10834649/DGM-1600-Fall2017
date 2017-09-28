using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	public string[] heroes = new string[6];



	// Use this for initialization
	void Start () {
		heroes[0] = "Batmanuel";
		heroes[1] = "Dora the Explorer";
		heroes[2] = "Kaladin Stormblessed";
		heroes[3] = "Ronny the Milkman";
		heroes[4] = "Carolus Rex XIV";
		heroes[5] = "Captain Hammer";

		print(heroes[3]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
