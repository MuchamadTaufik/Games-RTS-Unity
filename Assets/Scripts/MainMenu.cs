using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject subMenu;

    public GameObject smOptions;
    public GameObject smCredits;

    public Text tTitle;
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
    public void Next3()
    {
        SceneManager.LoadScene(3);
    }
    public void Next2()
    {
        SceneManager.LoadScene(0);
    }
    public void Next()
    {
        SceneManager.LoadScene(2);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void SubMenu()
    {
        if (subMenu.activeInHierarchy == false)
        {
            tTitle.text = EventSystem.current.currentSelectedGameObject.name;

            if (tTitle.text == "Credits")
            {
                smCredits.SetActive(true);
            } else
            {
                smOptions.SetActive(true);
            }

            subMenu.SetActive(true);
        }
        else
        {

            if (tTitle.text == "Credits")
            {
                smCredits.SetActive(false);
            } else
            {
                smOptions.SetActive(false);
            }

            subMenu.SetActive(false);
        }
    }

    public void Music()
    {
        if (music.mute == false)
        {
            tMusic.text = "Music : Off";
            music.mute = true;
        }
        else
        {
            tMusic.text = "Music : On";
            music.mute = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
