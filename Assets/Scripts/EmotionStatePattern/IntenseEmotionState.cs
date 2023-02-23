using UnityEngine;

public class IntenseEmotionState : EmotionState
{
    private float atmosphereThickness = 5f;
    private float skyExposure = 1.6f;
    private Color skyColor = new Color(0, 1, 0);
    private Color groundColor = new Color(0, 0, 0);
    private Color fogColor = new Color(70/255, 0, 0);
    private Color lightColor = new Color(62f/255, 62f/255, 62f/255);
    private float fogDensity = 0.015f;
    public override void initEnvironnement()
    {
        rain.Stop();
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