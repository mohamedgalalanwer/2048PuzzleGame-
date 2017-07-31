using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour {
    private Text tileText;
    private Image tileImage;
    private int nummber;
    public int indRaw, indCol;

    public int Number{
        set{ 
            nummber = value;
            if (nummber == 0) {
            
                SetEmpty ();
            } else {
            
                SetOnVisable ();
                ApplyStyle (nummber);
            
            }
        }
        get{ 
        
            return nummber;
        }

    }
	// Use this for initialization
	void Awake () {
        tileText = GetComponentInChildren<Text> ();
        tileImage = transform.Find ("tilePanel").GetComponent<Image> ();
	}
	
	// Update is called once per frame
    void ApplyStyleFromHolder (int index) {
        tileText.text = TileStyleHolder.instant.tileStyle [index].number.ToString();
        tileText.color = TileStyleHolder.instant.tileStyle [index].textColor;
        tileImage.color= TileStyleHolder.instant.tileStyle [index].tileColor;
	}
    void ApplyStyle(int num){
        switch (num) {
        case 2:
            ApplyStyleFromHolder (0);
            break;

        case 4:
            ApplyStyleFromHolder (1);
            break;
        case 8:
            ApplyStyleFromHolder (2);
            break;
        case 16:
            ApplyStyleFromHolder (3);
            break;case 32:
            ApplyStyleFromHolder (4);
            break;case 64:
            ApplyStyleFromHolder (5);
            break;case 128:
            ApplyStyleFromHolder (6);
            break;case 256:
            ApplyStyleFromHolder (7);
            break;case 512:
            ApplyStyleFromHolder (9);
            break;
        case 1024:
            ApplyStyleFromHolder (10);
            break;
        case 2048:
            ApplyStyleFromHolder (11);
            break;
        case 4096:
            ApplyStyleFromHolder (12);
            break;
        default:
            Debug.Log ("please check the number of index");
            break;


        }




    }

    private void SetOnVisable(){
        tileText.enabled = true;
        tileImage.enabled = true;
    }
    private void SetEmpty(){
    
        tileText.enabled = false;
        tileImage.enabled = false;
    }
}
