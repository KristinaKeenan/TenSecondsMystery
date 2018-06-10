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

	// Use this for initialization
	void Start () {
        
        clickedClueList = new List<Clue>();
        //int validClues = ;
        currentValidClues = 0;
        lengthCCL = -1;
        tempClueCount = 0;
		
        testRect = GameObject.Find("testRect").GetComponent<RectTransform>();
      //  blehRect = GameObject.Find("testRect").GetComponent<Rect>();
       // testRect.localScale = new Vector3(2f,1f,1f);
        testRect.Translate(1,10,0);
        
        
        //blehRect = Instantiate (testRect, new Rect(-217,101,35,118));
        //generateLine();
        
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

       // if(idkMath > 0){
            return(idkMath);
      //  }
       // else{
       //     return(idkMath+180);
      //  }
        
    }
    
    public void generateLine(float x1, float y1, float x2, float y2){
        
      //  float x1 = 500;
     //   float y1 = 69;
      //  float x2 = 83;
     //   float y2 = 301;
        print("x1: "+x1+" y1: "+y1);
        blehRect = Instantiate (testRect, new Vector3(x1,y1,0),Quaternion.identity);
        blehRect.transform.SetParent(canvas.transform);
        print("1: "+blehRect.position);
        blehRect.pivot = new Vector2(1, 0.5f);
     //   blehRect.sizeDelta = new Vector2 (381, 10);

        blehRect.sizeDelta = new Vector2 (calcDistPoints(x1,x2,y1,y2), 10);
     //   print(calcDistPoints(x1,x2,y1,y2));
     //   print(calcSlopePoints(x1,x2,y1,y2));

        blehRect.Rotate(0, 0, (int)(calcSlopePoints(x1,x2,y1,y2)));
        //blehRect.Rotate(0, 0, 180);

        blehRect.SetSiblingIndex (1);

    }
    
    
    
    
	// Update is called once per frame
	void Update () {
        
      
	}
}
