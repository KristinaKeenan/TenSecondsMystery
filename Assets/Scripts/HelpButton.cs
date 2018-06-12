using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour {

    public Button helpButton;
    
    public GameObject instructions;
    
	// Use this for initialization
	void Start () {
        helpButton = GameObject.Find("HelpButton").GetComponent<Button>();
        helpButton.onClick.AddListener(showInstructions);
        instructions.SetActive(false);

		
	}
	
    public void showInstructions(){
        
                    instructions.SetActive(true);
        
    }
    
	// Update is called once per frame
	void Update () {
        
         if (Input.GetKeyDown(KeyCode.R)){
                    instructions.SetActive(false);

            
        }
		
	}
}
