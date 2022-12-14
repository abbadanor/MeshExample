using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChangeScript : MonoBehaviour
{

    public AudioMixer mixer;
    
    public Slider slider;

    void Start() {
        //gets slider and sets the value to the saved playerpref
        slider.value = PlayerPrefs.GetFloat("sliderVal", 1f);
    }
    //changes volume and sets a playerprefs so that the chosen volume is saved
    public void OnSliderValueChanged(float value){
        mixer.SetFloat("Volume", Mathf.Lerp(-80f, 20f, value));
        PlayerPrefs.SetFloat("sliderVal", value);
    }
}
