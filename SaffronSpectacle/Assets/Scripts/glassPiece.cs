using UnityEngine;
using System.Collections;

public class glassPiece : MonoBehaviour {

    public int pieceForGlasses = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void interact()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<playerAttributes>().numberOfGlassPieces[pieceForGlasses]++;
        GameObject.Destroy(this.gameObject, .05f);


    }
}
