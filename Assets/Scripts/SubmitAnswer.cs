using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitAnswer : MonoBehaviour {
    
    public Button submitButton;
    
    public ClueBoard clueBoard;

	// Use this for initialization
	void Start () {
		submitButton = GameObject.Find("Submit").GetComponent<Button>();
        submitButton.onClick.AddListener(submitAnswer);
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
	}
	
    public void submitAnswer(){
        if(7 == clueBoard.currentValidClues && 7 == (clueBoard.lengthCCL+1)){
            print("You solved the mystery!");
        }
        else if((7==clueBoard.currentValidClues && 7!=(clueBoard.lengthCCL+1)) || ((clueBoard.lengthCCL+1)==clueBoard.currentValidClues && (clueBoard.currentValidClues!=7))){
            print("You're getting somewhere, but you'll need more evidence.");
            
        }
        else{
            print("This doesn't make any sense!");           
        }
        
        
    }
    
    
	// Update is called once per frame
	void Update () {
		
	}
}
