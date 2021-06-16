using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] private float zoomSpeed = 3f;
    [SerializeField] private float zoomInMax = 40f;
    [SerializeField] private float zoomOutMax = 90f;
    private CinemachineInputProvider inputProvider;
    private CinemachineFreeLook freecamera;

    private void Awake()
    {
        inputProvider = GetComponent<CinemachineInputProvider>();
        freecamera = GetComponent<CinemachineFreeLook>();
    }
    void Start()
    {

    }
    void Update()
    {
        float z = inputProvider.GetAxisValue(2);
        if (z != 0)
        {
            ZoomScreen(z);
        }
    }
    public void ZoomScreen(float increment)
    {
        float fov = freecamera.m_Lens.FieldOfView;
        float target = Mathf.Clamp(fov + increment, zoomInMax, zoomOutMax);
        freecamera.m_Lens.FieldOfView = Mathf.Lerp(fov, target, zoomSpeed * Time.deltaTime);
    }
}
