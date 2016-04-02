using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {


    public Vector3 hinge = new Vector3(0.0f,1.0f,0.0f);
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void interact()
    {
        InvokeRepeating("doorOpen",.01f,.1f);
    }

    void doorOpen()
    {
        this.transform.RotateAround(hinge, 1.0f);
    }
}
