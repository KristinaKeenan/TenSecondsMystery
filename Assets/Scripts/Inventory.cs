using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    
    public List<string> inventoryClues;
    
    public ClueBoard clueBoard;
    
    public Button startGame;
    public GameObject startScreen;

	// Use this for initialization
	void Start () {
        inventoryClues = new List<string>();
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
        startGame.onClick.AddListener(startGameFunc);
		
	}
    
    public void startGameFunc(){
        
        startScreen.SetActive(false);
        
    }
	
    public void addClue(string clueToAdd){
        //print("addingClue");
        //add clue to inventory
        inventoryClues.Add(clueToAdd);
        
        //make clue appear on board
        clueBoard.toggleImageVisibility(clueToAdd);
        
    }
    
    

    
    public void removeClue(string clueToRemove){
        
        //remove clue from inventory
        inventoryClues.Remove(clueToRemove);

        //make clue disappear from board
        clueBoard.toggleImageVisibilityR(clueToRemove);

        
    }
    
    
	// Update is called once per frame
	void Update () {
       /* 
        if (Input.GetKeyDown("space")){
            addClue("Blood");
            addClue("Photo");
            addClue("Wrench");
            addClue("Bracelet");
            addClue("Railing");
            addClue("Phone");
            addClue("Texts");
            addClue("Splinter");
            addClue("Bat");
            addClue("Stuff");


            
        }
        if (Input.GetKeyDown("up")){
            removeClue("Blood");
            
        }
        
           */
		
	}
}
