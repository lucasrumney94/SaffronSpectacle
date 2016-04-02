using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {

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
        this.transform.Translate(Vector3.up);
    }
}
