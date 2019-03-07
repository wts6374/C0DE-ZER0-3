using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject PauseMenu, PauseButton;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Option()
    {
        SceneManager.LoadScene(2);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Menuetwo()
    {
        object[] obj = FindObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<SlowDown>() != null)
            {
                if (g.GetComponent<SlowDown>().isActive)
                {
                    g.GetComponent<SlowDown>().isActive = false;
                }
            }
            if (g.GetComponent<RainCoin>() != null)
            {
                if (g.GetComponent<RainCoin>().isActive)
                {
                    g.GetComponent<RainCoin>().isActive = false;
                }
            }
            if (g.GetComponent<coinMagnet>() != null)
            {
                if (g.GetComponent<coinMagnet>().isActive)
                {
                    g.GetComponent<coinMagnet>().isActive = false;
                }
            }

        }
        SceneManager.LoadScene(3);
        
    }
    public void Playtwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        PauseMenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
}
