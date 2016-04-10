using UnityEngine;
using System.Collections;

public class playerAttributes : MonoBehaviour {

    public int[] numberOfGlassPieces = {0,0,0,0,0,0};
    public int[] numberOfGlassPiecesReq = { 2, 2, 2, 2, 2, 2 };
    public bool[] glassesAchieved = { false, false, false, false, false, false };
    public int highestGlassesAchieved = 0;

	// Use this for initialization
	void Start ()
    {

	}

    // Update is called once per frame
    void Update()
    {
        //This Block calculates the highest achieved glasses
        
        for (int i = 0; i < numberOfGlassPieces.Length; i++)
        {
            if (numberOfGlassPieces[i] >= numberOfGlassPiecesReq[i])
                glassesAchieved[i] = true;

            if (glassesAchieved[i])
                highestGlassesAchieved = i;
        }



        //Debug.Log(numberOfGlassPieces[0] + "  " + numberOfGlassPieces[1] + "  " + numberOfGlassPieces[2] + "  " + numberOfGlassPieces[3] + "  " + numberOfGlassPieces[4]);
	}
}
