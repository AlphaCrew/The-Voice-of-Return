using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private InputActions playerinput;
    private static bool paused = false;
    public GameObject menu;
    public GameObject settings;
    public GameObject menu1;
    public Rigidbody rb;
    public GameObject Player;
    public GameObject Respawn;
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
    public void RespawnAction()
    {
        rb.isKinematic = true;
        Player.transform.position = Respawn.transform.position;
        Player.transform.rotation = Respawn.transform.rotation;
        rb.isKinematic = false;
    }
    public void settingso()
    {
        menu1.SetActive(false);
        settings.SetActive(true);
    }
    public void settingsq()
    {
        menu1.SetActive(true);
        settings.SetActive(false);
    }
    public void quit()
    {
        Application.Quit();
    }
}

