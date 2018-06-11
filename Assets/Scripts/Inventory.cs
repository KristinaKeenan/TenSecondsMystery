using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    
    public List<string> inventoryClues;
    
    public ClueBoard clueBoard;

	// Use this for initialization
	void Start () {
        inventoryClues = new List<string>();
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
		
	}
	
    public void addClue(string clueToAdd){
        print("addingClue");
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
        
      /*  if (Input.GetKeyDown("space")){
            addClue("Blood");
            addClue("Photo");
            
        }
        if (Input.GetKeyDown("up")){
            removeClue("Blood");
            
        }
        
           */ 
		
	}
}
