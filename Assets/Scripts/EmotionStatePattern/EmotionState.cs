using UnityEngine;
public abstract class EmotionState{
    public Material sky = RenderSettings.skybox;
    public Light light = GameObject.Find("Directional light").GetComponent<Light>();
    public ParticleSystem rain = GameObject.Find("rain").GetComponent<ParticleSystem>();
    public abstract void initEnvironnement();
}