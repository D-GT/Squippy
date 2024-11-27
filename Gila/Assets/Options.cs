using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Options : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider SliderMaster, SliderBGM, SliderSFX;
    public AudioMixer Master;

    public void changeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
    public void ChangeMasterVolume()
    {
        Master.SetFloat("MasterVol", SliderMaster.value);
    }
    public void ChangeBGMVolume()
    {
        Master.SetFloat("BGMVol", SliderBGM.value);
    }
    public void ChangeSFXVolume()
    {
        Master.SetFloat("SFXVol", SliderSFX.value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
