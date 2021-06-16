// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""fa0b1eba-41ed-48ae-b387-5dc02fc132cc"",
            ""actions"": [
                {
                    ""name"": ""WS"",
                    ""type"": ""Button"",
                    ""id"": ""5a5416c5-a572-49ab-8395-d0d8bdf24b33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AD"",
                    ""type"": ""Button"",
                    ""id"": ""019d6bc4-7c41-485a-870f-386bb1a3f2d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""61f8f97f-ef63-4602-a301-ecde749a2001"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModeS"",
                    ""type"": ""Button"",
                    ""id"": ""a7ad6d34-2a73-4883-8990-94ccaa250250"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModeS2"",
                    ""type"": ""Button"",
                    ""id"": ""7bed8d7a-a9de-4f2d-893f-252833362b84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModeR"",
                    ""type"": ""Button"",
                    ""id"": ""b0063e69-1432-47cf-8259-c3bcc8f9587a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModeO"",
                    ""type"": ""Button"",
                    ""id"": ""02172369-c066-4a3c-bf56-0e7673b62840"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""c590a87f-8e88-45af-8a22-b9cb4d2b20af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""dc139724-363e-4c77-b6dc-1d2b6ff4722b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6fdcba6c-1012-43d4-89d3-e0f7af610e5e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WS"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d7eaf42b-7e93-42bb-a650-e2b01660d701"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a3000d9c-b1c2-4b71-bf3b-866bf28729ca"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2682ed8a-262c-4a8d-9423-eefe5a7f1374"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a983d116-ea8d-421a-8a56-3ee347ca191e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ce957b1b-8829-4c21-8d54-29342c2e451d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aa00a927-b046-4bb9-9743-830cc5b04fc3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af8c869c-4e83-458e-add0-4b1862afcb98"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModeS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69a135a3-ad9f-466e-ad2c-a15275d30c5a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModeS2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46766d13-1a26-4dff-b2e1-e7d36b5759b2"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModeR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6987c50-4407-4ea7-a834-9e1247622a0b"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModeO"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b87e6ac-bc8e-464d-973f-c86434ec19a9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7addd3a-eb53-44d5-a12b-b589e621133b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""ab846262-5af8-4449-ac1a-149c9bd3e543"",
            ""actions"": [
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""298db29f-2c7e-43b8-aa44-04218bba6d52"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0a291394-7d3c-47d6-b128-aad178e96392"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e1c6e6c-41dd-4e6d-9de0-4469ccd0617c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f27fb14f-f833-4c78-a810-d855ef6ffae1"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_WS = m_Keyboard.FindAction("WS", throwIfNotFound: true);
        m_Keyboard_AD = m_Keyboard.FindAction("AD", throwIfNotFound: true);
        m_Keyboard_Brake = m_Keyboard.FindAction("Brake", throwIfNotFound: true);
        m_Keyboard_ModeS = m_Keyboard.FindAction("ModeS", throwIfNotFound: true);
        m_Keyboard_ModeS2 = m_Keyboard.FindAction("ModeS2", throwIfNotFound: true);
        m_Keyboard_ModeR = m_Keyboard.FindAction("ModeR", throwIfNotFound: true);
        m_Keyboard_ModeO = m_Keyboard.FindAction("ModeO", throwIfNotFound: true);
        m_Keyboard_Respawn = m_Keyboard.FindAction("Respawn", throwIfNotFound: true);
        m_Keyboard_PauseGame = m_Keyboard.FindAction("PauseGame", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MouseLook = m_Mouse.FindAction("MouseLook", throwIfNotFound: true);
        m_Mouse_Zoom = m_Mouse.FindAction("Zoom", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_WS;
    private readonly InputAction m_Keyboard_AD;
    private readonly InputAction m_Keyboard_Brake;
    private readonly InputAction m_Keyboard_ModeS;
    private readonly InputAction m_Keyboard_ModeS2;
    private readonly InputAction m_Keyboard_ModeR;
    private readonly InputAction m_Keyboard_ModeO;
    private readonly InputAction m_Keyboard_Respawn;
    private readonly InputAction m_Keyboard_PauseGame;
    public struct KeyboardActions
    {
        private @InputActions m_Wrapper;
        public KeyboardActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WS => m_Wrapper.m_Keyboard_WS;
        public InputAction @AD => m_Wrapper.m_Keyboard_AD;
        public InputAction @Brake => m_Wrapper.m_Keyboard_Brake;
        public InputAction @ModeS => m_Wrapper.m_Keyboard_ModeS;
        public InputAction @ModeS2 => m_Wrapper.m_Keyboard_ModeS2;
        public InputAction @ModeR => m_Wrapper.m_Keyboard_ModeR;
        public InputAction @ModeO => m_Wrapper.m_Keyboard_ModeO;
        public InputAction @Respawn => m_Wrapper.m_Keyboard_Respawn;
        public InputAction @PauseGame => m_Wrapper.m_Keyboard_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @WS.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWS;
                @WS.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWS;
                @WS.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWS;
                @AD.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAD;
                @AD.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAD;
                @AD.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAD;
                @Brake.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBrake;
                @ModeS.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS;
                @ModeS.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS;
                @ModeS.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS;
                @ModeS2.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS2;
                @ModeS2.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS2;
                @ModeS2.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeS2;
                @ModeR.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeR;
                @ModeR.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeR;
                @ModeR.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeR;
                @ModeO.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeO;
                @ModeO.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeO;
                @ModeO.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnModeO;
                @Respawn.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRespawn;
                @Respawn.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRespawn;
                @Respawn.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRespawn;
                @PauseGame.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WS.started += instance.OnWS;
                @WS.performed += instance.OnWS;
                @WS.canceled += instance.OnWS;
                @AD.started += instance.OnAD;
                @AD.performed += instance.OnAD;
                @AD.canceled += instance.OnAD;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @ModeS.started += instance.OnModeS;
                @ModeS.performed += instance.OnModeS;
                @ModeS.canceled += instance.OnModeS;
                @ModeS2.started += instance.OnModeS2;
                @ModeS2.performed += instance.OnModeS2;
                @ModeS2.canceled += instance.OnModeS2;
                @ModeR.started += instance.OnModeR;
                @ModeR.performed += instance.OnModeR;
                @ModeR.canceled += instance.OnModeR;
                @ModeO.started += instance.OnModeO;
                @ModeO.performed += instance.OnModeO;
                @ModeO.canceled += instance.OnModeO;
                @Respawn.started += instance.OnRespawn;
                @Respawn.performed += instance.OnRespawn;
                @Respawn.canceled += instance.OnRespawn;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MouseLook;
    private readonly InputAction m_Mouse_Zoom;
    public struct MouseActions
    {
        private @InputActions m_Wrapper;
        public MouseActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLook => m_Wrapper.m_Mouse_MouseLook;
        public InputAction @Zoom => m_Wrapper.m_Mouse_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MouseLook.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
                @Zoom.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IKeyboardActions
    {
        void OnWS(InputAction.CallbackContext context);
        void OnAD(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnModeS(InputAction.CallbackContext context);
        void OnModeS2(InputAction.CallbackContext context);
        void OnModeR(InputAction.CallbackContext context);
        void OnModeO(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnMouseLook(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
