// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
            ""name"": ""Player Movement"",
            ""id"": ""4118e2d4-66e1-4f1b-951a-5fc9b4d0c4c4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d63c084-b069-4363-9bf7-f9bf59c0b1c4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2bb18002-f665-41b9-92ab-f5dd19adc56d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7bab66ca-f94c-4e5c-b402-1b9bbc77d6a0"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1b7b7f8-325a-4392-ae2d-e45c3d78cb68"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ca90eb69-56af-41a5-a7cf-909b70abc18d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73af8d26-f151-4d16-b7e8-b890a94bdb59"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""428a2796-e57c-4642-aa3c-82b9e2dc2d24"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""1e9d2e93-56a0-42fe-b5d8-ae69f17a6690"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84e52b42-e5a8-4ae6-a454-6264a95a75e0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""436309f5-5ec8-49ca-8889-59b78d9836de"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""edabf8dd-0271-4a96-bfe3-2a625e9c3460"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f02b5460-1f97-4640-a6e7-180f8ccadcdf"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2b702553-397a-4076-8181-fcbf98da3436"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Stick"",
                    ""id"": ""ffb88070-9396-4cda-bcc3-d66dda6458f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c3786f7-0832-47d3-8a91-82c0cab6f75b"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""be3442da-b5f3-4b82-bf65-2b0fd7a7457b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa834318-a125-4a3b-9be4-14d13ee946a0"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcebbe4c-b9a1-4f66-8a31-eca71a956ecb"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""4c4be442-b5c3-4bf4-8b61-3cd9f4007b65"",
            ""actions"": [
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""a7716d0a-80f7-4e7f-9f54-2ec289765359"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightAttackRight"",
                    ""type"": ""Button"",
                    ""id"": ""10eb8084-e614-40f7-9eae-11de2ba4ee04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavyAttackRight"",
                    ""type"": ""Button"",
                    ""id"": ""addf67bb-0774-40f2-8cc8-fcc1c3ef512d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightAttackLeft"",
                    ""type"": ""Button"",
                    ""id"": ""2b218241-f673-4ef9-9165-91c774225b3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavyAttackLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ce2b6e03-24f8-4cce-82c1-6dbf478e6691"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b945fa69-02a9-4ba0-a216-58993af4b386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d6c7081-1bdb-4e83-94de-8de73c7727ac"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cb3e34a-e0ae-48aa-9a5e-44d0bddb34dd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0f484e7-0dfa-4df4-a843-46f5d38fd558"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a20c15f9-8cb5-4f05-af5c-d1a08ce98937"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c85f81a0-27f1-4d3d-a171-a93cf5c5c282"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c47cb958-7fe1-4c0e-a0ce-c3c81078937b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc95bb1b-d7e8-4d01-a01e-381945ed4dd1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4db68dcd-1b6c-4c05-a5cb-6417ef77177c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba632190-1bff-420f-a937-24ce15d58444"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d95db47-b46f-473b-a3a0-52952e1f4c69"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93d54173-3b4e-4a07-ba84-9d92ac896dbe"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1a56c6c-a78d-4801-a80a-fd367f149e60"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon Select"",
            ""id"": ""4157cafd-2e24-4500-849e-793d2776728a"",
            ""actions"": [
                {
                    ""name"": ""Up Arrow"",
                    ""type"": ""Button"",
                    ""id"": ""7a793faa-9101-440c-9c6c-c363fdfc6e46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down Arrow"",
                    ""type"": ""Button"",
                    ""id"": ""2d22cc7e-3f3b-466a-a507-c0d3e97b92f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Arrow"",
                    ""type"": ""Button"",
                    ""id"": ""908f9de7-bfe0-427f-820f-00feefdb58ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Arrow"",
                    ""type"": ""Button"",
                    ""id"": ""e0fb6017-82a6-4709-848a-7a7feffea65d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""038e30dc-4e5a-4cdc-9044-4d8a7bb4bec5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a40be96-95e3-4eb6-ab39-f720cbb770ec"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0a09810-2327-4224-b2d3-407333685b82"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""980dbba8-a473-44ad-96d0-9b8768677afb"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""110b0f3e-d619-43c1-ac94-97d5a6fe2e5a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a04590a0-f32c-4018-bbfe-26688192e2fd"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8af29de0-ee3e-4061-892b-a03f7ccbe658"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd46c0e5-e0b2-498c-8a26-b118b813c8c7"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Arrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Roll = m_PlayerActions.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActions_LightAttackRight = m_PlayerActions.FindAction("LightAttackRight", throwIfNotFound: true);
        m_PlayerActions_HeavyAttackRight = m_PlayerActions.FindAction("HeavyAttackRight", throwIfNotFound: true);
        m_PlayerActions_LightAttackLeft = m_PlayerActions.FindAction("LightAttackLeft", throwIfNotFound: true);
        m_PlayerActions_HeavyAttackLeft = m_PlayerActions.FindAction("HeavyAttackLeft", throwIfNotFound: true);
        m_PlayerActions_Interact = m_PlayerActions.FindAction("Interact", throwIfNotFound: true);
        // Weapon Select
        m_WeaponSelect = asset.FindActionMap("Weapon Select", throwIfNotFound: true);
        m_WeaponSelect_UpArrow = m_WeaponSelect.FindAction("Up Arrow", throwIfNotFound: true);
        m_WeaponSelect_DownArrow = m_WeaponSelect.FindAction("Down Arrow", throwIfNotFound: true);
        m_WeaponSelect_LeftArrow = m_WeaponSelect.FindAction("Left Arrow", throwIfNotFound: true);
        m_WeaponSelect_RightArrow = m_WeaponSelect.FindAction("Right Arrow", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Roll;
    private readonly InputAction m_PlayerActions_LightAttackRight;
    private readonly InputAction m_PlayerActions_HeavyAttackRight;
    private readonly InputAction m_PlayerActions_LightAttackLeft;
    private readonly InputAction m_PlayerActions_HeavyAttackLeft;
    private readonly InputAction m_PlayerActions_Interact;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Roll => m_Wrapper.m_PlayerActions_Roll;
        public InputAction @LightAttackRight => m_Wrapper.m_PlayerActions_LightAttackRight;
        public InputAction @HeavyAttackRight => m_Wrapper.m_PlayerActions_HeavyAttackRight;
        public InputAction @LightAttackLeft => m_Wrapper.m_PlayerActions_LightAttackLeft;
        public InputAction @HeavyAttackLeft => m_Wrapper.m_PlayerActions_HeavyAttackLeft;
        public InputAction @Interact => m_Wrapper.m_PlayerActions_Interact;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Roll.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @LightAttackRight.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackRight;
                @LightAttackRight.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackRight;
                @LightAttackRight.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackRight;
                @HeavyAttackRight.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackRight;
                @HeavyAttackRight.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackRight;
                @HeavyAttackRight.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackRight;
                @LightAttackLeft.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackLeft;
                @LightAttackLeft.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackLeft;
                @LightAttackLeft.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttackLeft;
                @HeavyAttackLeft.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackLeft;
                @HeavyAttackLeft.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackLeft;
                @HeavyAttackLeft.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttackLeft;
                @Interact.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @LightAttackRight.started += instance.OnLightAttackRight;
                @LightAttackRight.performed += instance.OnLightAttackRight;
                @LightAttackRight.canceled += instance.OnLightAttackRight;
                @HeavyAttackRight.started += instance.OnHeavyAttackRight;
                @HeavyAttackRight.performed += instance.OnHeavyAttackRight;
                @HeavyAttackRight.canceled += instance.OnHeavyAttackRight;
                @LightAttackLeft.started += instance.OnLightAttackLeft;
                @LightAttackLeft.performed += instance.OnLightAttackLeft;
                @LightAttackLeft.canceled += instance.OnLightAttackLeft;
                @HeavyAttackLeft.started += instance.OnHeavyAttackLeft;
                @HeavyAttackLeft.performed += instance.OnHeavyAttackLeft;
                @HeavyAttackLeft.canceled += instance.OnHeavyAttackLeft;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // Weapon Select
    private readonly InputActionMap m_WeaponSelect;
    private IWeaponSelectActions m_WeaponSelectActionsCallbackInterface;
    private readonly InputAction m_WeaponSelect_UpArrow;
    private readonly InputAction m_WeaponSelect_DownArrow;
    private readonly InputAction m_WeaponSelect_LeftArrow;
    private readonly InputAction m_WeaponSelect_RightArrow;
    public struct WeaponSelectActions
    {
        private @PlayerControls m_Wrapper;
        public WeaponSelectActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UpArrow => m_Wrapper.m_WeaponSelect_UpArrow;
        public InputAction @DownArrow => m_Wrapper.m_WeaponSelect_DownArrow;
        public InputAction @LeftArrow => m_Wrapper.m_WeaponSelect_LeftArrow;
        public InputAction @RightArrow => m_Wrapper.m_WeaponSelect_RightArrow;
        public InputActionMap Get() { return m_Wrapper.m_WeaponSelect; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponSelectActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponSelectActions instance)
        {
            if (m_Wrapper.m_WeaponSelectActionsCallbackInterface != null)
            {
                @UpArrow.started -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnUpArrow;
                @UpArrow.performed -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnUpArrow;
                @UpArrow.canceled -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnUpArrow;
                @DownArrow.started -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnDownArrow;
                @DownArrow.performed -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnDownArrow;
                @DownArrow.canceled -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnDownArrow;
                @LeftArrow.started -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnLeftArrow;
                @LeftArrow.performed -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnLeftArrow;
                @LeftArrow.canceled -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnLeftArrow;
                @RightArrow.started -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnRightArrow;
                @RightArrow.performed -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnRightArrow;
                @RightArrow.canceled -= m_Wrapper.m_WeaponSelectActionsCallbackInterface.OnRightArrow;
            }
            m_Wrapper.m_WeaponSelectActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UpArrow.started += instance.OnUpArrow;
                @UpArrow.performed += instance.OnUpArrow;
                @UpArrow.canceled += instance.OnUpArrow;
                @DownArrow.started += instance.OnDownArrow;
                @DownArrow.performed += instance.OnDownArrow;
                @DownArrow.canceled += instance.OnDownArrow;
                @LeftArrow.started += instance.OnLeftArrow;
                @LeftArrow.performed += instance.OnLeftArrow;
                @LeftArrow.canceled += instance.OnLeftArrow;
                @RightArrow.started += instance.OnRightArrow;
                @RightArrow.performed += instance.OnRightArrow;
                @RightArrow.canceled += instance.OnRightArrow;
            }
        }
    }
    public WeaponSelectActions @WeaponSelect => new WeaponSelectActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnRoll(InputAction.CallbackContext context);
        void OnLightAttackRight(InputAction.CallbackContext context);
        void OnHeavyAttackRight(InputAction.CallbackContext context);
        void OnLightAttackLeft(InputAction.CallbackContext context);
        void OnHeavyAttackLeft(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IWeaponSelectActions
    {
        void OnUpArrow(InputAction.CallbackContext context);
        void OnDownArrow(InputAction.CallbackContext context);
        void OnLeftArrow(InputAction.CallbackContext context);
        void OnRightArrow(InputAction.CallbackContext context);
    }
}
