using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttoncode : MonoBehaviour
{
    public GameObject ex;

    public void Start()
    {
        Time.timeScale = 1f;
    }
    public void pause()
    {
        Time.timeScale = 0f;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void game()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void maps()
    {
        SceneManager.LoadScene(2);
    }
    public void controls()
    {
        SceneManager.LoadScene(3);
    }
    public void lightsettings()
    {
        SceneManager.LoadScene(4);
    }
    public void audiosettings()
    {
        SceneManager.LoadScene(5);
    }
    public void informationbox()
    {
        SceneManager.LoadScene(6);
    }
    public void statistics()
    {
        SceneManager.LoadScene(7);
    }
    public void desert()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
    public void polar()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
    }
    public void terriblejungle()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1f;
    }
    public void firstquitbutton()
    {
        ex.SetActive(true);
    }
    public void no()
    {
        ex.SetActive(false);
    }
    public void yes()
    {
        Application.Quit();
    }
    public void lighton()
    {
        GameObject.FindWithTag("light").SetActive(true);
    }
    public void lightoff()
    {
        GameObject.FindWithTag("light").SetActive(false);
    }
    public void gamemusicon()
    {
        GameObject.FindWithTag("music").GetComponent<AudioSource>().enabled = true;
    }
    public void gamemusicoff()
    {
        GameObject.FindWithTag("music").GetComponent<AudioSource>().enabled = false;
    }
    public void soundson()
    {
        GameObject.FindWithTag("sounds").GetComponent<AudioSource>().enabled = true;
    }
    public void soundsoff()
    {
        GameObject.FindWithTag("sounds").GetComponent<AudioSource>().enabled = false;
    }
}
