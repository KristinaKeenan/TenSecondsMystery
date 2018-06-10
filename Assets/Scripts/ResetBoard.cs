using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBoard : MonoBehaviour {

    
    public Button resetButton;
    
    public ClueBoard clueBoard;
    
	// Use this for initialization
	void Start () {
		resetButton = GameObject.Find("Reset").GetComponent<Button>();
        resetButton.onClick.AddListener(resetBoard);
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
	}
    
    public void resetBoard(){
        
        
        
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
