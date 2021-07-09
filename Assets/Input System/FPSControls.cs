// GENERATED AUTOMATICALLY FROM 'Assets/Input System/FPSControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPSControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPSControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPSControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""38613ef4-94c0-4cca-adaf-15c022b80f6e"",
            ""actions"": [
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ee09f6c-ea95-4ce5-9a17-9d3ad04910a8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Moving"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8cb1a83c-df7e-48b4-a636-c4314bbcc144"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4d28666d-8ba4-4a3f-afa2-3e0e4d346627"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""0050fc39-1c4f-464d-90c4-88475cff047a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSwap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""61023467-3d79-4392-95bf-b3699e7cdb1a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetTargets"",
                    ""type"": ""Button"",
                    ""id"": ""4ae95bcd-b98c-4726-977b-c45651070f68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f44f8a7f-a9ac-4dca-95d7-37dd264a98a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""28b13405-3498-4ec0-acd7-5a635d2e82cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwapQ"",
                    ""type"": ""Button"",
                    ""id"": ""e9b0a1c8-53e1-45c7-a23e-5695433b2370"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bbb41973-1db2-4e6b-adb7-0369c5c39f29"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0962fa4c-359e-4b26-bc6c-a4919a98120e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""597e0fe1-22a9-453f-a2db-a7edbb81ac1c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e3fe8ab-fd8c-400a-9d31-94ed13133553"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c6706ffd-e56f-4e47-a60c-67919fe7cb90"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e717d7a-6d42-418c-bae8-3d799751eaff"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""153e1ca7-fa79-4d82-8e61-3757474c9c79"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7da2c0a0-4f52-462d-9dca-84787ccf951c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cac2d5d0-18d2-4c0b-9aa3-2db666635e47"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6b6b265-f1b9-4c89-911a-0f3f9afcad14"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a80a1fbb-15da-4946-abf8-285ab1f9e9ef"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetTargets"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""791ae92a-4c13-429a-b6c1-547beb129c68"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2a639f6-e5c8-4202-afef-5df499af5992"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""875ed9dc-d5d5-4fa2-b4ae-8b1d79e22252"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwapQ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_CameraControl = m_Player.FindAction("CameraControl", throwIfNotFound: true);
        m_Player_Moving = m_Player.FindAction("Moving", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Shooting = m_Player.FindAction("Shooting", throwIfNotFound: true);
        m_Player_WeaponSwap = m_Player.FindAction("WeaponSwap", throwIfNotFound: true);
        m_Player_ResetTargets = m_Player.FindAction("ResetTargets", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_SwapQ = m_Player.FindAction("SwapQ", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_CameraControl;
    private readonly InputAction m_Player_Moving;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Shooting;
    private readonly InputAction m_Player_WeaponSwap;
    private readonly InputAction m_Player_ResetTargets;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_SwapQ;
    public struct PlayerActions
    {
        private @FPSControls m_Wrapper;
        public PlayerActions(@FPSControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraControl => m_Wrapper.m_Player_CameraControl;
        public InputAction @Moving => m_Wrapper.m_Player_Moving;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Shooting => m_Wrapper.m_Player_Shooting;
        public InputAction @WeaponSwap => m_Wrapper.m_Player_WeaponSwap;
        public InputAction @ResetTargets => m_Wrapper.m_Player_ResetTargets;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @SwapQ => m_Wrapper.m_Player_SwapQ;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @CameraControl.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @Moving.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Moving.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Moving.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Shooting.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
                @WeaponSwap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwap;
                @WeaponSwap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwap;
                @WeaponSwap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwap;
                @ResetTargets.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetTargets;
                @ResetTargets.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetTargets;
                @ResetTargets.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetTargets;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @SwapQ.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapQ;
                @SwapQ.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapQ;
                @SwapQ.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapQ;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @Moving.started += instance.OnMoving;
                @Moving.performed += instance.OnMoving;
                @Moving.canceled += instance.OnMoving;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
                @WeaponSwap.started += instance.OnWeaponSwap;
                @WeaponSwap.performed += instance.OnWeaponSwap;
                @WeaponSwap.canceled += instance.OnWeaponSwap;
                @ResetTargets.started += instance.OnResetTargets;
                @ResetTargets.performed += instance.OnResetTargets;
                @ResetTargets.canceled += instance.OnResetTargets;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @SwapQ.started += instance.OnSwapQ;
                @SwapQ.performed += instance.OnSwapQ;
                @SwapQ.canceled += instance.OnSwapQ;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnCameraControl(InputAction.CallbackContext context);
        void OnMoving(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnWeaponSwap(InputAction.CallbackContext context);
        void OnResetTargets(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnSwapQ(InputAction.CallbackContext context);
    }
}
