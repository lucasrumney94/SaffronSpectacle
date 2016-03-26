using UnityEngine;
using System.Collections;

public class applyGlassesBlur : MonoBehaviour {

    private UnityStandardAssets.ImageEffects.BlurOptimized optimizedBlur;
    private int highestGlassesAchieved;
    
	// Use this for initialization
	void Start ()
    {
        optimizedBlur = this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.BlurOptimized>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        highestGlassesAchieved = GameObject.FindGameObjectWithTag("Player").GetComponent<playerAttributes>().highestGlassesAchieved;
        optimizedBlur.blurSize = 10 - (2 * (highestGlassesAchieved));
        if (highestGlassesAchieved > 0)
        {
            optimizedBlur.blurIterations = 3;
            optimizedBlur.downsample = 1;
        }
        if (highestGlassesAchieved > 1)
        {
            optimizedBlur.blurIterations = 2;
        }
        if (highestGlassesAchieved > 2)
        {
            optimizedBlur.blurIterations = 2;
            optimizedBlur.downsample = 0;
        }
        if (highestGlassesAchieved > 3)
        {
            optimizedBlur.blurIterations = 1;
        }
        if (highestGlassesAchieved == 5)
        {
            optimizedBlur.enabled = false;
        }
	}
}
