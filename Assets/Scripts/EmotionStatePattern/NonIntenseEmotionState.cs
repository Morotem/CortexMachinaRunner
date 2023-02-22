public class NonIntenseEmotionState : EmotionState
{
    public override void initEnvironnement()
    {
        sky.SetFloat("_AtmosphereThickness", 0.1f);
    }
}