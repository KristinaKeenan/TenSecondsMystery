using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitAnswer : MonoBehaviour {
    
    public Button submitButton;
    
    public ClueBoard clueBoard;
    
    public GameObject submitBad, submitGood;

	// Use this for initialization
	void Start () {
		submitButton = GameObject.Find("Submit").GetComponent<Button>();
        submitButton.onClick.AddListener(submitAnswer);
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
        submitBad = GameObject.Find("SubmitBAD");
        submitGood = GameObject.Find("SubmitGOOD");

        submitBad.SetActive(false);
        submitGood.SetActive(false);

	}
	
    public void submitAnswer(){
        if(7 == clueBoard.currentValidClues && 7 == (clueBoard.lengthCCL+1)){
            submitGood.SetActive(true);
        
        
        }
        else{
            
            submitBad.SetActive(true);
            
        }
       /* else if((7==clueBoard.currentValidClues && 7!=(clueBoard.lengthCCL+1)) || ((clueBoard.lengthCCL+1)==clueBoard.currentValidClues && (clueBoard.currentValidClues!=7))){
            print("You're getting somewhere, but you'll need more evidence.");
            
        }
        else{
            print("This doesn't make any sense!");           
        }*/
        
        
    }
    
    
	// Update is called once per frame
	void Update () {
        
         if (Input.GetKeyDown(KeyCode.R)){
                    submitBad.SetActive(false);

            
        }
        
        if (Input.GetKey("escape"))
            Application.Quit();
		
	}
}
