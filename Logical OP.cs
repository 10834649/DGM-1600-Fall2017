using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {
	public string luke = "jedi";

	public string vader = "sith";

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";
	public int num1 = 10;

	public float num2 = 10.5f;


	public bool leia = true;



	// Use this for initialization
	void Start () {
	// 	if(luke == "jedi" && vader == "nanny"){
	// 		print ("Vader is Your Nanny");
	// }
	// 	else if (luke == "jawa" && vader == "sith"){
	// 		print ("utini!");
	// 	}
	// 	else if (luke == "jedi" && vader == "sith"){
	// 		print ("Noooooo! Thats not true... Thats impossible!");
	// 	}
	// 	else 
	// 		print ("The End");

	// if(leia){
	// 	print("No, there is another.");
	// }
	// else if(!leia){
	// 	print("Hurray! Now I can date Luke!");
	// }
	// else 
	// 	print("Han shot first.");

	// if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
	// 	print("Meesa gonna Kill ya. Meesa sith Lorda");

	// }

	// else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
	// 	print("As you wish!");
	// }

	// else 
	// 	print("No Anakin, Not the Younglings!");
	
	if (num1 == 10 && num2 == 10.5f){
		print("Dang Straight!");
	
	}
	else if(num1 == 10 && num2 == 10f){
		print("Heck no, ya punk.");
	}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	}
