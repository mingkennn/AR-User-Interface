using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public Canvas startMenu;
    public Canvas settingsMenu;
    public Canvas playingMenu;

    public AudioMixer mixer;

    private bool Paused = false;

    // Start initialises the game when it first starts
    void Start()
    {
        settingsMenu.gameObject.SetActive(false);
        playingMenu.gameObject.SetActive(false);
        startMenu.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Paused == true)
        {

        } else {
            
        }
    }

    public void changeStartPlay()
    {
        startMenu.gameObject.SetActive(false);
        playingMenu.gameObject.SetActive(true);
    }

    public void changePlaySettings()
    {
        playingMenu.gameObject.SetActive(false);
        Paused = true;
        settingsMenu.gameObject.SetActive(true);
    }

    public void changeSettingsPlay()
    {
        settingsMenu.gameObject.SetActive(false);
        Paused = false;
        playingMenu.gameObject.SetActive(true);
    }

    public void changeSettingsStart()
    {
        settingsMenu.gameObject.SetActive(false);
        Paused = false;
        startMenu.gameObject.SetActive(true);
    }

    public void volumeMute()
    {
        mixer.SetFloat("",0f);
    }

    public void volumeLow()
    {
        float value;
        bool result = mixer.GetFloat("mixer", out value);
        value -= 0.1f;
        if (value < 0.1f)
        {
            value = 0.1f;
            mixer.SetFloat("", value);
        }
        else
        {
            mixer.SetFloat("", value);
        }
    }

    public void volumeMax()
    {
        float value;
        bool result = mixer.GetFloat("mixer", out value);
        value += 0.1f;
        if (value > 1f)
        {
            value = 1f;
            mixer.SetFloat("", value);
        }
        else
        {
            mixer.SetFloat("", value);
        }
    }




}