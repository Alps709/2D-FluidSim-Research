// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerGamepad"",
            ""id"": ""516650a0-0298-419c-b930-c5143bbe83e3"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""dc87bcf2-5525-4ce1-8009-ad8cff2c3ef4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""36c300cc-0860-4178-84fd-51f548ee6ff3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f0c76150-5f6f-4b32-8b6f-dfa6b11893a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""47549401-4f54-45cf-a876-1da6c2a2ee01"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f7624cd8-4439-44fc-8b40-8f41324e3853"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53979ad1-cdb2-4e73-ba15-c60a831740cf"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b126233-fdc9-4b18-93c9-2a093d27882c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a36d1cf-eec2-4307-990b-0d6e8660d203"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40cff69d-8cbe-425a-b471-596a7fac582d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerKeyboard"",
            ""id"": ""37485b2a-bad8-4536-8554-f3e0c66f9453"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""f5434410-7f2e-47dd-ad17-cba5e22127a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""81395b8f-3b44-4c7d-9a17-dacb7fa9191f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e61c5f1a-d2f2-4e02-b333-227bd58ee049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""612fd07d-5b21-4421-bd50-7835e5c90f81"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""52092a6a-af8c-421d-8500-9fff1a6dbb19"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a2aebb22-ad6e-4f0e-8831-9325dfb24325"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a204f575-c694-40dc-a719-12fd7a4a2e30"",
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
                    ""id"": ""be5dc761-6c25-45fa-bd5f-7d3053f0ef89"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerGamepad
        m_PlayerGamepad = asset.FindActionMap("PlayerGamepad", throwIfNotFound: true);
        m_PlayerGamepad_HorizontalMovement = m_PlayerGamepad.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerGamepad_Jump = m_PlayerGamepad.FindAction("Jump", throwIfNotFound: true);
        m_PlayerGamepad_Shoot = m_PlayerGamepad.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerGamepad_Aim = m_PlayerGamepad.FindAction("Aim", throwIfNotFound: true);
        // PlayerKeyboard
        m_PlayerKeyboard = asset.FindActionMap("PlayerKeyboard", throwIfNotFound: true);
        m_PlayerKeyboard_HorizontalMovement = m_PlayerKeyboard.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerKeyboard_Jump = m_PlayerKeyboard.FindAction("Jump", throwIfNotFound: true);
        m_PlayerKeyboard_Shoot = m_PlayerKeyboard.FindAction("Shoot", throwIfNotFound: true);
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

    // PlayerGamepad
    private readonly InputActionMap m_PlayerGamepad;
    private IPlayerGamepadActions m_PlayerGamepadActionsCallbackInterface;
    private readonly InputAction m_PlayerGamepad_HorizontalMovement;
    private readonly InputAction m_PlayerGamepad_Jump;
    private readonly InputAction m_PlayerGamepad_Shoot;
    private readonly InputAction m_PlayerGamepad_Aim;
    public struct PlayerGamepadActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerGamepadActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerGamepad_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_PlayerGamepad_Jump;
        public InputAction @Shoot => m_Wrapper.m_PlayerGamepad_Shoot;
        public InputAction @Aim => m_Wrapper.m_PlayerGamepad_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGamepadActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGamepadActions instance)
        {
            if (m_Wrapper.m_PlayerGamepadActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnShoot;
                @Aim.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerGamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerGamepadActions @PlayerGamepad => new PlayerGamepadActions(this);

    // PlayerKeyboard
    private readonly InputActionMap m_PlayerKeyboard;
    private IPlayerKeyboardActions m_PlayerKeyboardActionsCallbackInterface;
    private readonly InputAction m_PlayerKeyboard_HorizontalMovement;
    private readonly InputAction m_PlayerKeyboard_Jump;
    private readonly InputAction m_PlayerKeyboard_Shoot;
    public struct PlayerKeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerKeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerKeyboard_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_PlayerKeyboard_Jump;
        public InputAction @Shoot => m_Wrapper.m_PlayerKeyboard_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKeyboardActions instance)
        {
            if (m_Wrapper.m_PlayerKeyboardActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerKeyboardActions @PlayerKeyboard => new PlayerKeyboardActions(this);
    public interface IPlayerGamepadActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface IPlayerKeyboardActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
