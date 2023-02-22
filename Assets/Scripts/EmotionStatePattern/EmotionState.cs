using UnityEngine;
public abstract class EmotionState{
    public Material sky = RenderSettings.skybox;
    public abstract void initEnvironnement();
}