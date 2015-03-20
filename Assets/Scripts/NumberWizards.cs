using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {

	public Text guessText;
	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess;
	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = max + 1;
		NextGuess ();
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	public void GuessCorrect() {
		StartGame();
	}

	void NextGuess() {
		guess = Random.Range (min, max);
		print ("Next guess is " + guess);
		guessText.text = guess.ToString();
	}


	// Update is called once per frame

}
