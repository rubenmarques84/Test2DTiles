using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    
    public GameObject character;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Update is called once per frame
    void OnGUI()
    {

    }

    public void createNewCharacterTest()
    {
        GameObject character = (GameObject)Instantiate(Resources.Load("characterPrefab"));
        GameObject map = GameObject.Find("MapMainGrid");
        GridController mapController = map.GetComponent<GridController>();
        mapController.HighLightGrids();
        //Debug.Log();


    }
}
