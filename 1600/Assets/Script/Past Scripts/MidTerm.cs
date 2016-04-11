using UnityEngine;
using System.Collections;

public class MidTerm : MonoBehaviour {
	//public class allows the component to be seen in the inspector, MidTerm is the name of the component, MonoBehavior marks a base class.

	public int myInt = 6;
	//public allows the integer to be seen and edited in the inspector, int marks the start or creation of an integer to be used in some sort of function, myInt = marks what the integer is called, 6 is the integer itself.
	float coffeeTemperature = 85.0f;
	//float is used when there is a decimal, coffeeTemperature = indicates what the variable of the coffee temperature will be, 85.0f; is the what the coder set the default "coffee temperature" as, the f is used when it is a float.
	private float hotLimitTemperature = 70.0f;
	// private makes it so the variable cannot be seen or edited in the inspector, float is used when there is a decimal, hotLimitTemperature = sets the limit to the "temperature" so that anything below the limit is not considered "hot", 70.0f is what the limit actually is set as, f is used for a float.
	public float coldLimitTemperature = 40.0f;
	//public allows the variable to be seen or edited in the inspector, float is used when there is a decimal, coldLimitTemperature = is used to show that anything above the number is no longer "cold", 40.0f is the number of the limit, f is used in a float.
	int numEnemies = 3;
	//int marks the creations of another integer, numEnemies = is the name of the integer, 3 is the actual integer itself.
	private MidTerm myMidterm;
	//private makes it so that this part of the component cannot be seen or edited in the inspector, MidTerm is the name of the component, my Midterm;  
	public GameObject[] players;
	//public allows the this variable to be seen or edited in the inspector, GameObject[] marks that you want to tag onto a gameobject in Untiy, players; is what the tag is. public GameObject[] players; is also part of an Array or indicates an Array.

	void Start ()
	//void indicates that whatever follows is not affected by what is above it and I believe Start just names this certain part of the script.
	{
		TemperatureTest();
		//TemperatureTest(); marks what the action taken after pressing play is called.
		Debug.Log (myInt);
		//Debug.Log writes a message to the console which in this cases is the myInt.

		for(int i = 0; i < numEnemies; i++)
			//for marks the start of a for loop and will continue to be shown in the console until the integer i is not longer < numEnemies, int marks the creation of an integer, i = is what the integer is called, 0 is what the integer actually is, i < numEnemies; states that i has to be less that the number of enemies, numEnemies grabs the integer that was created earlier, i++ indicates that i will continue to go up by 1 every time. 
		{
			Debug.Log("Creating enemy number: " + i);
			//Debug.Log writes the message to the console and it appears it is usually what is in the parenthesis, ("Creating enemy number: " + i); is what is going to be shown in the console (it will show what is in the quotations and what i equals.
		}
		myMidterm = GetComponent<MidTerm>();
		//myMidterm = indicates that another type of component is being created, GetComponent<MidTerm>(); is what the component or variable of myMidterm will be (it also lets the script know that you want it to grab the component of MidTerm). 

		for(int i = 0; i < players.Length; i++)
			//for marks the start of another for loop, the players name will continue to appear until there are no more players, int i = 0 creates another integer that equals 0, i < player.Length; indicates that i has to be less than the amount of players, i++ means that the integer i will continue to increase until it is no longer less than the amount of players.
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
			//Debug.Log writes the message to the console, ("Player Number "+i+" is named "+players[i].name); is the message that is displayed, the quotations are directly written to the console but i is changed to the number it is on and players[i].name changes to the name of the player or gameobject that is tagged as a player.
		}

		Direction myDirection;
		//Directions marks the start of an enumeration that is called myDirection.

		myDirection = Direction.North;
		//myDirection = Direction.North; indicates that myDirection will always be the Direction.North and will start as this. 

		ReverseDirection (myDirection);
		//ReverseDirection is an action that it will do to the myDirection, the direction will reverse.

	}

	void Update ()
	//void again takes off any of the above functions and Update in a way marks that the Start part is being updated. 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			//if marks the start of an if statement or a conditional, (Input.GetKeyDown(KeyCode.Space)) makes an input that allows an action to occur if a key is pressed (in this case the key that does the input is the space bar.
			TemperatureTest();
		//I believe TemperatureTest(); indicates what occurs if the space bar is pressed. In other words, because of the if statement above, every time the space bar is pressed Unity will check what number the temperature is at and will type in the console whatever the number implies whether it is over the hot limit or below the cold limit.

		coffeeTemperature -= Time.deltaTime * 5f;
		//coffeeTemperature indicates that what the integer was stated above is being used in this function, I think -= Time.deltaTime * 5f indicates that the coffee temperature will go down by 5 increments each time, the f is used because the coffee temperature was set as a float. 
	}

	void TemperatureTest ()
	//void again takes off any of the above functions and starts a new action known as TemperatureTest
	{
		string tooHot = "Coffee is too hot.";
		//string compares the words, tooHot = indicates that another variable is being made and in this case whenever you see tooHot it actually means "Coffee is too hot."
		if(coffeeTemperature > hotLimitTemperature)
			//if marks another if statement, (coffeeTemperature > hotLimitTemperature) this is the conditional and it says that if the "coffee temperature" is more than the "hot limit" than whatever follows this statement is supposed to occur. In this case it's a print.
		{
			print(tooHot);
			//print shows what is to be printed if the if statement is not met (if the coffee temperature is more than the hot limit), (tooHot) is what printed on the console. 
		}
	}

	enum Direction{North, East, South, West};
	//enum is the start of an enumeration, enumerations are a list of constants, Direction is the name of the list, {North, East, South, West}; are all the constants in the list.

	void ReverseDirection (Direction dir)
	//void again takes off the functions that are not in this section, ReverseDirection is what this particular function or action is called, (Direction dir) indicates that this action will be using the enumeration of Direction and I believe is given a shorter name hence the dir.
	{
		if(dir == Direction.North)
			//if marks an if statement and in this case i believe the if statement indicates that if the default direction is North then the reverse of it is South, (dir == Direction.North) is the condition.
			dir = Direction.South;
		//dir = Direction.South; is what the direction is when reversed.


	}

	void Greet()
	// void again takes off the functions that are not in this section, Greet is what this function or action is called.
	{
		switch (myInt)
		//switch indicates the start of a switch statement which works similarly to an if statement, it goes case by case until there is a match (if there is no match it goes to the default), (myInt) brings the integer that was previously named as myInt
		{
		case 5:
			//case indicates a different conditional that the Unity tries to match myInt to.The number after case indicates which integer it is comparing myInt to.
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//break indicates the next part or the next case is different and that if the integer does not match this case then it moves on to the next case.
		case 4:
			//case indicates a different conditional that the Unity tries to match myInt to.The number after case indicates which integer it is comparing myInt to.
			print ("Hello and good day!");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//break indicates the next part or the next case is different and that if the integer does not match this case then it moves on to the next case.
		case 3:
			//case indicates a different conditional that the Unity tries to match myInt to.The number after case indicates which integer it is comparing myInt to.
			print ("Whadya want?");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//break indicates the next part or the next case is different and that if the integer does not match this case then it moves on to the next case.
		case 2:
			//case indicates a different conditional that the Unity tries to match myInt to.The number after case indicates which integer it is comparing myInt to.
			print ("Grog SMASH!");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//break indicates the next part or the next case is different and that if the integer does not match this case then it moves on to the next case.
		case 1:
			//case indicates a different conditional that the Unity tries to match myInt to.The number after case indicates which integer it is comparing myInt to.
			print ("Ulg, glib, Pblblblblb");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//break indicates the next part or the next case is different and that if the integer does not match this case then it moves on to the next case.
		default:
			//this default case occurs if the integer does not fit any of the other cases.
			print ("Incorrect intelligence level.");
			//print indicates that what ever follows it in quotations should be printed in the console of Unity, ("..."); indicates what exactly should be typed in the console.
			break;
			//this break would indicate the end of the different cases.
		}
	}
}