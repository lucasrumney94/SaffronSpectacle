using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {

    public float interactionRange = 10.0f;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        if (Input.GetButtonDown("Interact"))
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            RaycastHit hitObject;
            
            if (Physics.Raycast(transform.position, fwd, out hitObject, interactionRange))
                hitObject.collider.gameObject.SendMessage("interact", SendMessageOptions.DontRequireReceiver);

        }
    }
}
