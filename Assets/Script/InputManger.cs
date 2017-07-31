using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MoveDirection{

    Rigth,Left,Up,Down
}
public class InputManger : MonoBehaviour {
    GameManger mg;
    void Awake(){
        mg = GameManger.FindObjectOfType<GameManger> ();
    
    
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            //move right
            mg.Move(MoveDirection.Rigth);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            //move Left
            mg.Move(MoveDirection.Left);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            //move Down
            mg.Move(MoveDirection.Down);
        } if(Input.GetKeyDown(KeyCode.UpArrow)){
            //move Up
            mg.Move(MoveDirection.Up);
        }

	}
}
