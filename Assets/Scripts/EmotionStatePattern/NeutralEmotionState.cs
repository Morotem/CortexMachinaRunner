using UnityEngine;

public class NeutralEmotionState : EmotionState
{
    private float atmosphereThickness = 0.7f;
    private float skyExposure = 2.07f;
    private Color skyColor = new Color(51f/255, 158f/255, 212f/255);
    private Color groundColor = new Color(125f/255, 125f/255, 125f/255);
    private Color fogColor = new Color(200f/255, 1, 1);
    private Color lightColor = new Color(1, 219f/255, 136f/255);
    private float fogDensity = 0.005f;
    public override void initEnvironnement()
    {
        rain.Stop();
        intenseTrail.Stop();
        nonIntenseTrail.Stop();
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