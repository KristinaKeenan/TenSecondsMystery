using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableOverlap : MonoBehaviour {
   
    public GameObject interactUI;
    public GameObject closeup;
    
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
                
                print("Opening image");
                closeup.SetActive(true);
                interactUI.SetActive(false);
                
            }
        }
	}
}
