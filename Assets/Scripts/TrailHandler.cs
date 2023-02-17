using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailHandler : MonoBehaviour
{
    public ParticleSystem excitedTrail;
    public ParticleSystem happyTrail;
    public ParticleSystem positiveMoodTrail;
    public ParticleSystem negativeMoodTrail;
    public ParticleSystem sadTrail;
    public ParticleSystem hateTrail;

    public EmotionWeight emotions = new EmotionWeight{
        Excited = 0,
        Happy = 0,
        PositiveMood = 0,
        NegativeMood = 0,
        Sad = 0,
        Hate = 0
    };
    // Start is called before the first frame update
    void Start()
    {
        desactiveAllTrails();
    }

    // Update is called once per frame
    void Update()
    {
        manageInput();
        if(emotions.Excited == 1){
            if(excitedTrail.isPlaying) return;
            desactiveAllTrails();
            excitedTrail.Play();
        }
        if(emotions.Happy == 1){
            if(happyTrail.isPlaying) return;
            desactiveAllTrails();
            happyTrail.Play();
        }
        if(emotions.PositiveMood == 1){
            if(positiveMoodTrail.isPlaying) return;
            desactiveAllTrails();
            positiveMoodTrail.Play();
        }
        if(emotions.NegativeMood == 1){
            if(negativeMoodTrail.isPlaying) return;
            desactiveAllTrails();
            negativeMoodTrail.Play();
        }
        if(emotions.Sad == 1){
            if(sadTrail.isPlaying) return;
            desactiveAllTrails();
            sadTrail.Play();
        }
        if(emotions.Hate == 1){
            if(hateTrail.isPlaying) return;
            desactiveAllTrails();
            hateTrail.Play();
        }
    }


    void desactiveAllTrails(){
        excitedTrail.Stop();
        happyTrail.Stop();
        positiveMoodTrail.Stop();
        negativeMoodTrail.Stop();
        sadTrail.Stop();
        hateTrail.Stop();
    }

    //will be removed when data will came from headset
    void resetData(){
        emotions = new EmotionWeight{
            Excited = 0,
            Happy = 0,
            PositiveMood = 0,
            NegativeMood = 0,
            Sad = 0,
            Hate = 0
        };
    }

    void manageInput(){
        if(Input.GetKeyDown(KeyCode.Q)){
            resetData();
            emotions.Excited = 1;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            resetData();
            emotions.Happy = 1;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            resetData();
            emotions.PositiveMood = 1;
        }
        if(Input.GetKeyDown(KeyCode.F)){
            resetData();
            emotions.NegativeMood = 1;
        }
        if(Input.GetKeyDown(KeyCode.G)){
            resetData();
            emotions.Sad = 1;
        }
        if(Input.GetKeyDown(KeyCode.H)){
            resetData();
            emotions.Hate = 1;
        }
    }


}
