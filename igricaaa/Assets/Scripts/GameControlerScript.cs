﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlerScript : MonoBehaviour {

	[SerializeField]
	private Sprite bgImage;
	
	public Sprite[] puzzles;
	
	public List<Sprite> gamePuzzles = new List<Sprite>();
	
	
     public List<Button> btns = new List<Button>();
	 
	 private bool firstGuess, secondGuess;
	 
	 private int countGuesses=0;
	 private int countCorrectGuesses;
	 private int gameGuesses;
	 
	 private int firstGuessIndex, secondGuessIndex;
	 
	 private string firstGuessPuzzle, secondGuessPuzzle;
	

	
	
	public AudioClip soundgood, soundbad, finalsound;
private Button button {get { return GetComponent<Button>(); } }
private AudioSource source { get { return GetComponent<AudioSource>();}}
	

	// Use this for initialization
	
	
	void PlaySound1(){
		source.PlayOneShot(soundgood);
	}
	void PlaySound(){
		source.PlayOneShot(soundbad);
	}
	void PlaySound2(){
		source.PlayOneShot(finalsound);
	}
	 
	 void Awake(){
		// puzzles = Resources.LoadAll<Sprite>("Sprites/beatles");
	 }

	void Start(){
		GetButtons();
		AddListeners();
		AddGamePuzzles();
		Shuffle(gamePuzzles);
		gameGuesses = 16 / 2;
		gameObject.AddComponent<AudioSource>();
		source.clip = soundgood;
		source.playOnAwake = false;
		
	}
	void AddGamePuzzles(){
		int looper = btns.Count;
		int index = 0;
		
		for(int i = 0; i<looper;i++){
			if(index == looper / 2){
				index = 0;
			}
			gamePuzzles.Add(puzzles[index]);
			index++;
		}
	}
	
	void GetButtons(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");
		
		for(int i = 0; i<objects.Length; i++){
			btns.Add(objects[i].GetComponent<Button>());
			btns[i].image.sprite = bgImage;
		}
	}
	void AddListeners(){
		foreach(Button btn in btns){
			btn.onClick.AddListener(() => PickAPuzzle());
		}
	}
	public void PickAPuzzle(){
		//string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
		//Debug.Log("You are clicking a button named " + name);
		
		if(!firstGuess){
			firstGuess = true;
			
			firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
			
			btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
			
		}
		else if(!secondGuess){
			secondGuess = true;
			
			secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
			btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
		StartCoroutine(CheckIfThePuzzlesMatch());
		/*if(firstGuessPuzzle == secondGuessPuzzle){
			Debug.Log("Match");
		}
			else {Debug.Log("Dont match");
		}*/
		}
		
	}
	
	
	IEnumerator CheckIfThePuzzlesMatch(){
		yield return new WaitForSeconds(1f);
		
		if(firstGuessPuzzle == secondGuessPuzzle){
			
			yield return new WaitForSeconds(.5f);
			
			PlaySound1();
	
			btns[firstGuessIndex].interactable = false;
			btns[secondGuessIndex].interactable = false;
			
			btns[firstGuessIndex].image.color = new Color(0,0,0,0);
			
			btns[secondGuessIndex].image.color = new Color(0,0,0,0);
			
			CheckIfTheGameIsFinished();
		}
		else{
			yield return new WaitForSeconds(.5f);
		PlaySound();
			btns[firstGuessIndex].image.sprite = bgImage;
			btns[secondGuessIndex].image.sprite = bgImage;
		}
		yield return new WaitForSeconds(.5f);
		firstGuess = secondGuess = false;
	}
	
	void CheckIfTheGameIsFinished(){
		countCorrectGuesses++;
		
		if(countCorrectGuesses == gameGuesses){
			PlaySound2();
			Debug.Log("Game Finished!");
			Debug.Log("It took you " + countGuesses + " many guesses to finish the game!");
			
		}
	}
	void Shuffle(List<Sprite>list){
		for(int i = 0; i<list.Count; i++){
			Sprite temp = list[i];
			int randomIndex = Random.Range(i,list.Count);
			list[i] = list[randomIndex];
			list[randomIndex] = temp;
		}
	}
}    //Game Controller











