using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    public Slider BGMSlider;
    public float BGMsoundValue;
    public Sprite YesSound;
    public Sprite NoSound;
    public float BeforeBGMVolume;
    public GameObject BGMbtn;
    bool IsSave;
    void Start()
    {
        BGMsoundValue = PlayerPrefs.GetFloat("BGMvolume");
        IsSave = IsSave = PlayerPrefs.HasKey("saved_game");
        if(!IsSave){
            musicsource.volume=1;
            BGMSlider.value = 1;
        }
        else{
            musicsource.volume = BGMsoundValue;
            BGMSlider.value = BGMsoundValue;

        }
    }
    void Update()
    {

    }
    public void SetMusicVolum(float volume)
    {
        musicsource.volume = volume;
        PlayerPrefs.SetFloat("BGMvolume",volume);
    }
    public void ClickBGMbtn()
    {
        if(musicsource.volume>0)
        {
            BeforeBGMVolume=musicsource.volume;
            BGMbtn.GetComponent<Image>().sprite=NoSound;
            BGMSlider.value=0;
            SetMusicVolum(0);
        }
        else if(musicsource.volume==0){
            BGMbtn.GetComponent<Image>().sprite=YesSound;
            BGMSlider.value=BeforeBGMVolume;
            SetMusicVolum(BeforeBGMVolume);
        }
        
    }

}
