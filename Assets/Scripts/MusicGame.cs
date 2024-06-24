using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicGame : MonoBehaviour
{
    public AudioSource music;
    public Text tMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Music()
    {
        if (music.mute == false)
        {
            tMusic.text = "---";
            music.mute = true;
        }
        else
        {
            tMusic.text = "";
            music.mute = false;
        }
    }
}
