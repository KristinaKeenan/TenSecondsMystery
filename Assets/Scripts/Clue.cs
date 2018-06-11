
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
    public Button clueButton;
    public bool imgVisible;
    
    
    //the clues that are connected to this one by string
    public bool connection1;
    public bool connection2;
    public int numConnections;
    
    public bool inClueList;
    
    public bool canInteract;
    
    //is it clicked on the board
    public bool isSelected;
    
    //its index in ClueList
    public int posInClueList;
    
    public ClueBoard clueBoard;
    
    public Clue selfClue;
    
    
    public Image tack;
    
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
        numConnections = 0;
        tack.enabled = false;

        clueBoard.transform.Find(clueName).gameObject.SetActive(false);

        
        
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
        
        clueButton.onClick.AddListener(onButtonClick);
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
        clueBoard.transform.Find(clueName).gameObject.SetActive(true);

        }
        else{
            // img code off
        clueBoard.transform.Find(clueName).gameObject.SetActive(false);

        }
    }
    
    //might not need
    public void toggleInteraction(){
        
        canInteract = !canInteract;
        
        if(canInteract){
            // toggle on
            clueButton.enabled = true;
        }
        else{
            // toggle off
            clueButton.enabled = false;

        }
    }
    
    //onclick
    public void onButtonClick(){
        
        tack.enabled = true;
       // if(numConnections < 2){
        
        if(!inClueList){
        clueBoard.addToCCL(selfClue);

        if(clueBoard.tempClueCount == 0){
            clueBoard.tempClueCount++;
            clueBoard.tempClue1 = selfClue;
            }
            else{
                clueBoard.tempClue2 = selfClue;
                
                if(clueBoard.tempClue1!=clueBoard.tempClue2){

                if(clueBoard.tempClue1.boardImg.GetComponent<RectTransform>().position.x < clueBoard.tempClue2.boardImg.GetComponent<RectTransform>().position.x){
                    
                    clueBoard.generateLine(clueBoard.tempClue2.boardImg.GetComponent<RectTransform>().position.x,clueBoard.tempClue2.boardImg.GetComponent<RectTransform>().position.y,clueBoard.tempClue1.boardImg.GetComponent<RectTransform>().position.x,clueBoard.tempClue1.boardImg.GetComponent<RectTransform>().position.y);
                    
                    
                }else{
             
                    
                clueBoard.generateLine(clueBoard.tempClue1.boardImg.GetComponent<RectTransform>().position.x,clueBoard.tempClue1.boardImg.GetComponent<RectTransform>().position.y,clueBoard.tempClue2.boardImg.GetComponent<RectTransform>().position.x,clueBoard.tempClue2.boardImg.GetComponent<RectTransform>().position.y);
            
            
                }
            
                
            
                clueBoard.tempClueCount = 1;
                    clueBoard.tempClue1 = clueBoard.tempClue2;
            }

            }
        }
       // }
                numConnections++;

        
    }
    
	// Update is called once per frame
	void Update () {
        
	}
}
