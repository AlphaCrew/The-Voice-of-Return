using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSpeed;
    [SerializeField] private float zoomInMax = 40f;
    [SerializeField] private float zoomOutMax = 90f;
    private CinemachineInputProvider inputProvider;
    private CinemachineFreeLook freecamera;
    public Slider mainSlider;

    private void Awake()
    {
        inputProvider = GetComponent<CinemachineInputProvider>();
        freecamera = GetComponent<CinemachineFreeLook>();
    }
    void Start()
    {
        LoadPlayer();
        mainSlider.value = zoomSpeed;
    }
    void Update()
    {
        float z = inputProvider.GetAxisValue(2);
        if (z != 0)
        {
            ZoomScreen(z);
        }
        LoadPlayer();
        ChangezoomSpeed();
    }
    public void ZoomScreen(float increment)
    {
        float fov = freecamera.m_Lens.FieldOfView;
        float target = Mathf.Clamp(fov + increment, zoomInMax, zoomOutMax);
        freecamera.m_Lens.FieldOfView = Mathf.Lerp(fov, target, zoomSpeed * Time.deltaTime);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        zoomSpeed = data.zoomSpeed;
        Debug.Log(zoomSpeed);
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    #region UI Methods
    public void ChangezoomSpeed()
    {
        zoomSpeed = mainSlider.value;
        SavePlayer();
    }

    #endregion
}
