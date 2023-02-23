using UnityEngine;
public abstract class EmotionState{
    public Material sky = RenderSettings.skybox;
    public Light light = GameObject.Find("Directional light").GetComponent<Light>();
    public ParticleSystem rain = GameObject.Find("Rain").GetComponent<ParticleSystem>();
    public ParticleSystem intenseTrail = GameObject.Find("Intense").GetComponent<ParticleSystem>();
    public ParticleSystem nonIntenseTrail = GameObject.Find("Non-Intense").GetComponent<ParticleSystem>();
    public abstract void initEnvironnement();
}