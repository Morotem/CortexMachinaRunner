using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScript : MonoBehaviour
{
    public Material sky;
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = sky;
    }

    // Update is called once per frame
    void Update()
    {
        sky.SetFloat("_AtmosphereThickness", (player.concentration/20f));
        sky.SetFloat("_Exposure", (player.concentration/20f));
        DynamicGI.UpdateEnvironment();
    }
}
