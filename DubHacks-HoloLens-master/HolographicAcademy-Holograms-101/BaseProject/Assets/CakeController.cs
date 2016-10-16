using UnityEngine;
using System.Collections;

public class CakeController : MonoBehaviour {


    GameObject myWaffle;
    GameObject myChef;

    // Use this for initialization
    void Start () {
        //look through heirarchy for gameobject called waffle
        myWaffle = GameObject.Find("Waffle");
        myChef = GameObject.Find("Charakter_Chef");

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelect()
    {
        Debug.Log("hi");

        foreach (Renderer r in myWaffle.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
        foreach (Renderer r in myChef.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
    }
}
