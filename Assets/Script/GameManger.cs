using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {
    Tile [,]allTiles=new Tile[4,4];
	// Use this for initialization
	void Start () {
        Tile[] allTilesOnDim = GameObject.FindObjectsOfType<Tile> ();
        foreach (Tile t in allTilesOnDim) {
        
            t.Number = 0;
            allTiles [t.indRaw, t.indCol] = t;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Move(MoveDirection md){
    
        Debug.Log (md.ToString () + " Move");
    }
}
