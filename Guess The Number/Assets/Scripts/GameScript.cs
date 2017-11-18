using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public InputField input;
	public Text infoText;

	private int guessNumber;
	private int usersGuess;

	// Use this for initialization
	void Start () {
		guessNumber = Random.Range (0, 100);
	}
	
	public void checkGuess(){
		usersGuess = int.Parse(input.text);

		if (guessNumber == usersGuess) {
			infoText.text = "You guessed the number. You Won. Guess a number again!";
			Start ();
		} else if (usersGuess > guessNumber) {
			infoText.text = "Your number is big !!";
		} else {
			infoText.text = "Your number is small !!";
		}

		input.text = "";
	}
}
