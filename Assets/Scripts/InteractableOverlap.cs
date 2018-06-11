using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableOverlap : MonoBehaviour {
   
    public GameObject interactUI;
    public GameObject closeup;
    public AudioSource cameraClick;
    public Inventory inventory;
    public string clueName;
    public Canvas clueBoard;
    
    
    void Start(){
        
                clueBoard.enabled = false;

    }
    
    
	void OnTriggerEnter(Collider other){
        
        interactUI.SetActive(true);
        
    }
    
    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("space")){
             
            if (interactUI.activeSelf == true){
                
                cameraClick.Play();
                closeup.SetActive(true);
                interactUI.SetActive(false);   
            }
        }
            
        if(Input.GetKeyDown("return")){
            
            if(closeup.activeSelf == true){
                    
                    //add to inventory
                    //connect to inventory script
                    inventory.addClue(clueName);
                    
                
                    //close window
                    closeup.SetActive(false);
                    
                } 
            }
        
        if(Input.GetKeyDown("delete")){
            
            if(closeup.activeSelf == true){
                    
                    //don't add to inventory
                    
                    //close window
                    closeup.SetActive(false);
                    
                } 
            }
        if(Input.GetKeyDown(KeyCode.Return)){
            
            
                    clueBoard.enabled = true;

        }    
    
    
    }
	}
