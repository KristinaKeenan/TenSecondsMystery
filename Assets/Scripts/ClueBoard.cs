using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueBoard : MonoBehaviour {
    
    public List<Clue> clickedClueList;
    public int validClues;
    public int currentValidClues;
    public int lengthCCL;

	// Use this for initialization
	void Start () {
        
        clickedClueList = new List<Clue>();
        //int validClues = ;
        currentValidClues = 0;
        lengthCCL = -1;
		
	}
	
    public void resetCCL(){
        clickedClueList = new List<Clue>();
        currentValidClues = 0;
        lengthCCL = -1;
    }
    
    public void addToCCL(Clue clickedClue){
        
        if(!clickedClue.inClueList && !clickedClue.isSelected){
            clickedClueList.Add(clickedClue);
            lengthCCL++;
            clickedClue.posInClueList = lengthCCL;
            clickedClue.isSelected = true;
            
            if(clickedClue.isValid){
                currentValidClues++;
            }
                
        }
        else if(clickedClue.isSelected){
            //clickedClueList.Remove(clickedClue.posInClueList);
            lengthCCL--;
            clickedClue.isSelected = false;
            
            if(!clickedClue.isValid){
                currentValidClues--;
            }

        }
    }
    
    public void submitBoard(){
        
        
        if(10 == currentValidClues && 10 == (lengthCCL+1)){
            print("You solved the mystery!");
        }
        else if((10==currentValidClues && 10!=(lengthCCL+1)) || ((lengthCCL+1)==currentValidClues && (currentValidClues!=10))){
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
