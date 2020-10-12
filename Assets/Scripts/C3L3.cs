using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class C3L3 : MonoBehaviour {
	public int myInteger = 5;
	public float myFloat = 3.5f;
	public bool myBoolean = true;
	public string myString = "Hello World";
	public int[] myArrayOfInts;

	private int _myPrivateInteger = 10;
	float _myPrivateFloat = -5.0f;

	// Start is called before the first frame update
	void Start() {
		/** OPERATORS **/
		/* 
		 Math operators: +, -, *, /, %
		 Last operator is "module", it returns the rest of a division
		*/
		Debug.Log("let's sum 10 to myInteger. Right now its value is " + myInteger);
		myInteger = myInteger + 10;
		Debug.Log("After the sum the value is " + myInteger);

		// Calling a function
		IsEven(myInteger);

		// Calling inside an if
		if (IsEven(myInteger)) {
			MyDebug("myInteger is even!!!");
		}
		else {
			MyDebug("myInteger is odd!!");
		}

		int totalSum = this.myArrayOfInts.Where(x => this.IsEven(x)).Sum();
		this.MyDebug("Total sum of even numbers is " + totalSum);

		/** COMPARISONS **/
		/*
		 Operators ==, >, <, >=, <= (equal to, greather than, less than, greather or equal to, less or equal to)
		*/
		if (myFloat >= 2f) {
			MyDebug("myFloat is greather or equal than 2");
		}

		// Besides, we can combine comparisons
		if (IsEven(_myPrivateInteger) && _myPrivateInteger == 10) { // Operator AND
			MyDebug("_myPrivateInteger is 10!!");
		}

		if (IsEven(myInteger) || IsEven(_myPrivateInteger)) { // Operator OR
			MyDebug("any of the two variables is ok to me and want to execute some code");
		}

		/** FLOW CONTROL **/
		for (int i = 0; i < 10; i++) {
			Debug.Log(i); // Print numbers from 0 to 9 (check i < 10, never 10)
		}

		Debug.Log("Array's content");
		for (int i = 0; i < myArrayOfInts.Length; i++) {
			Debug.Log(myArrayOfInts[i]); // Print array's content, array[i] takes the content in that index (i) from the array
		}

		/** UNITY'S UTILITIES IN PROGRAMMING! **/

		// Get a component from THIS object
		SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>(); // This can be null and the game can crash!

		if (mySpriteRenderer != null) {
			MyDebug("I can use mySpriteRenderer");
		}
		else {
			MyDebug("The game will crash if you try to use the component!");
		}

		// Find object in the scene
		GameObject anObjectWithSpriteRenderer = FindObjectOfType<SpriteRenderer>().gameObject;

		GameObject anObjectWithTag = GameObject.FindWithTag("Player");

		GameObject anObjectWithName = GameObject.Find("Whatever name you now");

		// Enable or disable components
		if (mySpriteRenderer != null) {
			mySpriteRenderer.enabled = false; // true
		}

		// Enable disable gameobjects
		if (anObjectWithName != null) {
			anObjectWithName.SetActive(false); // true
		}
	}

	// Update is called once per frame
	void Update() {

	}

	/** FUNCIONES PRIVADAS **/

	bool IsEven(int num) {
		if (num % 2 == 0) {
			return true;
		}
		else {
			return false;
		}
	}

	void MyDebug(string message) {
		// Debug a message
		Debug.Log(message);
	}
}
