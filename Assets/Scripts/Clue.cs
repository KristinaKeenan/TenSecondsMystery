
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue : MonoBehaviour {
    
    public string clueName;
    public bool inInv;
    public bool isValid;
    
    
    //deals with the board image
    public GameObject boardImg;
    public bool imgVisible;
    
    
    //the clues that are connected to this one by string
    public bool connection1;
    public bool connection2;
    
    public bool inClueList;
    
    public bool canInteract;
    
    //is it clicked on the board
    public bool isSelected;
    
    //its index in ClueList
    public int posInClueList;
    
	// Use this for initialization
	void Start () {
        //initialize variables
        inInv = false;
        imgVisible = false;
        connection1 = false;
        connection2 = false;
        inClueList = false;
		isSelected = false;
        posInClueList = -1;
        
        boardImg.active = true;
	}
	
    public string addToInventory(){
        inInv = true;
        return clueName;
    }
    
    public void removeFromInventory(){
        inInv = false;
    }
    
    public void toggleImageVisibility(){
        imgVisible = !imgVisible;
        
        if(imgVisible){
            // img code on
            boardImg.active = true;

        }
        else{
            // img code off
            boardImg.active = false;

        }
    }
    
    public void toggleInteraction(){
        
        canInteract = !canInteract;
        
        if(canInteract){
            // toggle on
        }
        else{
            // toggle off
        }
    }
    
	// Update is called once per frame
	void Update () {
        
	}
}
