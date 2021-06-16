using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private InputActions playerinput;
    private static bool paused = false;
    public GameObject menu;
    private void Awake()
    {
        playerinput = new InputActions();
    }
    private void OnEnable()
    {
        playerinput.Enable();
    }
    private void OnDisable()
    {
        playerinput.Disable();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
        menu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        paused = false;
        menu.SetActive(false);
    }

    IEnumerator test()
    {
        yield return new WaitForSecondsRealtime(3);
    }

    private void Start()
    {
        playerinput.Keyboard.PauseGame.performed += _ => DeterminePause();
    }

    private void DeterminePause()
    {
        if (paused)
            ResumeGame();
        else
            PauseGame();
    }
    public void quit()
    {
        Application.Quit();
    }
}

