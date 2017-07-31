using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class StyleTile{
    public int number;
    public Color32 tileColor;
    public Color32 textColor;


}
public class TileStyleHolder : MonoBehaviour {

	// Use this for initialization

    //Senglton
    public static TileStyleHolder instant;
    public StyleTile[] tileStyle;
	void Awake () {
        instant = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
