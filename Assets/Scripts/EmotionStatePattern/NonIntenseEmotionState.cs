using UnityEngine;

public class NonIntenseEmotionState : EmotionState
{
    private float atmosphereThickness = 0.7f;
    private float skyExposure = 2.07f;
    private Color skyColor = new Color(51/255, 158/255, 212/255);
    private Color groundColor = new Color(125f/255, 125f/255, 125f/255);
    private Color fogColor = new Color(170/255, 232/255, 255/255);
    private Color lightColor = new Color(1, 219f/255, 136f/255);
    private float fogDensity = 0.005f;
    public override void initEnvironnement()
    {
        rain.Play();
        sky.SetFloat("_AtmosphereThickness", atmosphereThickness);
        sky.SetFloat("_Exposure", skyExposure);
        sky.SetColor("_SkyTint", skyColor);
        sky.SetColor("_GroundTint", groundColor);
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogDensity = fogDensity;
        light.color = lightColor;
        DynamicGI.UpdateEnvironment();
    }
}