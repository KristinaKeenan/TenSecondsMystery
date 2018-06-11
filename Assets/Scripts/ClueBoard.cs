using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueBoard : MonoBehaviour {
    
    public List<Clue> clickedClueList;
    public int validClues;
    public int currentValidClues;
    //keeping track of index for ccl
    public int lengthCCL;
    
    public RectTransform testRect;
    public RectTransform blehRect;
    
    public Canvas canvas;
    
    public Clue tempClue1, tempClue2;
    public int tempClueCount;
    
    public ClueBoard clueBoard;

	// Use this for initialization
	void Start () {
        
        clickedClueList = new List<Clue>();
        currentValidClues = 0;
        lengthCCL = -1;
        tempClueCount = 0;
		
        testRect = GameObject.Find("testRect").GetComponent<RectTransform>();
        testRect.Translate(1,10,0);
        
        clueBoard = GameObject.Find("clueBoard").GetComponent<ClueBoard>();
        
     
        
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
       /* else if(clickedClue.isSelected){
            clickedClueList.Remove(clickedClue);
            lengthCCL--;
            clickedClue.isSelected = false;
            
            if(clickedClue.isValid){
                currentValidClues--;
            }

        }*/
    }

    
    
    
    public int calcDistPoints(float x1,float x2,float y1,float y2){
        
        return (int)Mathf.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
        
    }
    
    public float calcSlopePoints(float x1, float x2, float y1, float y2){
        
       
        float slope = (y2-y1)/(x2-x1);
        print("slope: "+slope);
        float idkMath = ((Mathf.Atan(slope)) * 180) / Mathf.PI;
        print(idkMath + "testinghere");

            return(idkMath);
     
        
    }
    
    public void generateLine(float x1, float y1, float x2, float y2){
     
        blehRect = Instantiate (testRect, new Vector3(x1,y1,0),Quaternion.identity);
        blehRect.transform.SetParent(canvas.transform);
        blehRect.pivot = new Vector2(1, 0.5f);

        blehRect.sizeDelta = new Vector2 (calcDistPoints(x1,x2,y1,y2), 10);


        blehRect.Rotate(0, 0, (int)(calcSlopePoints(x1,x2,y1,y2)));

        blehRect.SetSiblingIndex (1);

    }
    
    
    
    
     public void toggleImageVisibility(string clueName){
    
        clueBoard.transform.Find(clueName).gameObject.SetActive(true);


    }
    
    public void toggleImageVisibilityR(string clueName){
        
        clueBoard.transform.Find(clueName).gameObject.SetActive(false);

        
    }
    
	// Update is called once per frame
	void Update () {
        
      
	}
}
