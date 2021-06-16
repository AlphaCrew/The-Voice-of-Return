using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    #region helper
    [System.Serializable]
    public struct WheelInfo
    {
        public Transform visualwheel;
        public WheelCollider wheelcollider;
    }
    #endregion

    public float motor = 800;
    public float steer = 50;
    public float brake = 440;
    public WheelInfo WBR;
    public WheelInfo WFR;
    public WheelInfo WBL;
    public WheelInfo WFL;
    private InputActions playerinput;
    public Rigidbody rb;
    public float mode = 1, modeR;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Respawn;

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
    void Start()
    {
        GetTheWheels();
    }
    void FixedUpdate()
    {
        float movementZ = playerinput.Keyboard.WS.ReadValue<float>();
        float movementX = playerinput.Keyboard.AD.ReadValue<float>();
        float brakebutton = playerinput.Keyboard.Brake.ReadValue<float>();
        if (mode == 1 || playerinput.Keyboard.ModeS.ReadValue<float>() == 1)
        {
            WFL.wheelcollider.motorTorque = movementZ * motor;
            WFL.wheelcollider.steerAngle = movementX * steer;
            WFR.wheelcollider.motorTorque = movementZ * motor;
            WFR.wheelcollider.steerAngle = movementX * steer;
            WBL.wheelcollider.motorTorque = movementZ * motor;
            WBL.wheelcollider.steerAngle = 0;
            WBR.wheelcollider.motorTorque = movementZ * motor;
            WBR.wheelcollider.steerAngle = 0;
            mode = 1;
        }

        if (mode == 2 || playerinput.Keyboard.ModeS2.ReadValue<float>() == 1)
        {
            WFL.wheelcollider.motorTorque = movementZ * motor;
            WFL.wheelcollider.steerAngle = 0;
            WFR.wheelcollider.motorTorque = movementZ * motor;
            WFR.wheelcollider.steerAngle = 0;
            WBL.wheelcollider.motorTorque = movementZ * motor;
            WBL.wheelcollider.steerAngle = movementX * -1 * steer;
            WBR.wheelcollider.motorTorque = movementZ * motor;
            WBR.wheelcollider.steerAngle = movementX * -1 *steer;
            mode = 2;
        }

        if (mode == 3 || playerinput.Keyboard.ModeR.ReadValue<float>() == 1)
        {
            if (movementX == 1)
            {
                WFL.wheelcollider.motorTorque = movementX * motor;
                WFL.wheelcollider.steerAngle = movementX * steer;
                WFR.wheelcollider.motorTorque = movementX * motor * -1;
                WFR.wheelcollider.steerAngle = movementX * steer * -1;
                WBL.wheelcollider.motorTorque = movementX * motor;
                WBL.wheelcollider.steerAngle = movementX * steer * -1;
                WBR.wheelcollider.motorTorque = movementX * motor * -1;
                WBR.wheelcollider.steerAngle = movementX * steer;
            }

            if (movementX == -1)
            {
                WFL.wheelcollider.motorTorque = movementX * motor;
                WFL.wheelcollider.steerAngle = movementX * steer * -1;
                WFR.wheelcollider.motorTorque = movementX * motor * -1;
                WFR.wheelcollider.steerAngle = movementX * steer;
                WBL.wheelcollider.motorTorque = movementX * motor;
                WBL.wheelcollider.steerAngle = movementX * steer;
                WBR.wheelcollider.motorTorque = movementX * motor * -1;
                WBR.wheelcollider.steerAngle = movementX * steer * -1;
            }

            if (movementX == 0)
            {
                WFL.wheelcollider.motorTorque = movementZ * motor;
                WFL.wheelcollider.steerAngle = 0;
                WFR.wheelcollider.motorTorque = movementZ * motor;
                WFR.wheelcollider.steerAngle = 0;
                WBL.wheelcollider.motorTorque = movementZ * motor;
                WBL.wheelcollider.steerAngle = 0;
                WBR.wheelcollider.motorTorque = movementZ * motor;
                WBR.wheelcollider.steerAngle = 0;
            }

            mode = 3;
        }
        if (mode == 4 || playerinput.Keyboard.ModeO.ReadValue<float>() == 1)
        {
            WFL.wheelcollider.motorTorque = movementZ * motor;
            WFL.wheelcollider.steerAngle = movementX * steer;
            WFR.wheelcollider.motorTorque = movementZ * motor;
            WFR.wheelcollider.steerAngle = movementX * steer;
            WBL.wheelcollider.motorTorque = movementZ * motor;
            WBL.wheelcollider.steerAngle = movementX * steer;
            WBR.wheelcollider.motorTorque = movementZ * motor;
            WBR.wheelcollider.steerAngle = movementX * steer;
            mode = 4;
        }


        if (brakebutton == 1)
        {
            WFL.wheelcollider.brakeTorque = brake;
            WFR.wheelcollider.brakeTorque = brake;
            WBL.wheelcollider.brakeTorque = brake;
            WBR.wheelcollider.brakeTorque = brake;
        }
        else
        {
            WFL.wheelcollider.brakeTorque = 0;
            WFR.wheelcollider.brakeTorque = 0;
            WBL.wheelcollider.brakeTorque = 0;
            WBR.wheelcollider.brakeTorque = 0;
        }
        if (rb.velocity.magnitude > motor)
        {
            WFL.wheelcollider.motorTorque = 0;
            WFR.wheelcollider.motorTorque = 0;
            WBL.wheelcollider.motorTorque = 0;
            WBR.wheelcollider.motorTorque = 0;
        }

        UpdateVisualWheels();
        if (playerinput.Keyboard.Respawn.ReadValue<float>() == 1)
        {
            rb.isKinematic = true;
            Player.transform.position = Respawn.transform.position;
            Player.transform.rotation = Respawn.transform.rotation;
            rb.isKinematic = false;
        }

    }
    private void UpdateVisualWheels()
    {
        Vector3 pos;
        Quaternion rot;

        WFL.wheelcollider.GetWorldPose(out pos, out rot);
        WFL.visualwheel.position = pos;
        WFL.visualwheel.rotation = rot;

        WFR.wheelcollider.GetWorldPose(out pos, out rot);
        WFR.visualwheel.position = pos;
        WFR.visualwheel.rotation = rot;

        WBL.wheelcollider.GetWorldPose(out pos, out rot);
        WBL.visualwheel.position = pos;
        WBL.visualwheel.rotation = rot;

        WBR.wheelcollider.GetWorldPose(out pos, out rot);
        WBR.visualwheel.position = pos;
        WBR.visualwheel.rotation = rot;
    }
    private void GetTheWheels()
    {
        GameObject wheels = GetChildByName(this.gameObject, "Wheels");
        WFL.visualwheel = GetChildByName(wheels, "WFL").transform;
        WFR.visualwheel = GetChildByName(wheels, "WFR").transform;
        WBL.visualwheel = GetChildByName(wheels, "WBL").transform;
        WBR.visualwheel = GetChildByName(wheels, "WBR").transform;

        GameObject colliders = GetChildByName(this.gameObject, "Colliders");
        WFL.wheelcollider = GetChildByName(colliders, "WCFL").GetComponent<WheelCollider>();
        WFR.wheelcollider = GetChildByName(colliders, "WCFR").GetComponent<WheelCollider>();
        WBL.wheelcollider = GetChildByName(colliders, "WCBL").GetComponent<WheelCollider>();
        WBR.wheelcollider = GetChildByName(colliders, "WCBR").GetComponent<WheelCollider>();
    }
    private GameObject GetChildByName(GameObject go, string name)
    {
        for (int i = 0; 1 < go.transform.childCount; i++)
        {
            if (go.transform.GetChild(i).name == name)
            {
                return go.transform.GetChild(i).gameObject;
            }
        }

        Debug.LogError("Error: Could not find child gameobject" + name + ", check speeling and case");
        return null;
    }
}