using UnityEngine;
using System.Collections;

public class applyGlassesDoF : MonoBehaviour
{

    private UnityStandardAssets.ImageEffects.DepthOfField DoF;
    private int highestGlassesAchieved;

    // Use this for initialization
    void Start()
    {
        DoF = this.gameObject.GetComponent<UnityStandardAssets.ImageEffects.DepthOfField>();
    }

    // Update is called once per frame
    void Update()
    {
        highestGlassesAchieved = GameObject.FindGameObjectWithTag("Player").GetComponent<playerAttributes>().highestGlassesAchieved;
        
            //.blurSize = 10 - (2 * (highestGlassesAchieved));
        if (highestGlassesAchieved > 0)
        {
            DoF.focalSize = 1.0f;
        }
        if (highestGlassesAchieved > 1)
        {
            DoF.focalSize = 0.5f;
            DoF.aperture = 0.8f;
        }
        if (highestGlassesAchieved > 2)
        {
            DoF.focalSize = 0.5f;
            DoF.aperture = 0.6f;
        }
        if (highestGlassesAchieved > 3)
        {
            DoF.focalSize = 0.5f;
            DoF.aperture = 0.5f;

        }
        if (highestGlassesAchieved == 5)
        {
            DoF.enabled = false;
        }
    }
}
