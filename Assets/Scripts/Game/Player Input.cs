//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Game/Player Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Input"",
    ""maps"": [
        {
            ""name"": ""PlayerKeebordInput"",
            ""id"": ""9c9d3bec-88dd-4034-bd05-69d662617223"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""073ddbd4-222b-4492-a15e-d9883b9f5ce3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f2300723-6fe0-419e-a1c0-cff524de95bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9faa1627-8ded-47c0-97d1-5c4dc21f285b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""ba54de4d-bfe8-437e-b1f1-d6ac3cfb480f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""8d962792-f6a5-4f0a-aa84-d3d72e139dc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""2eeea17e-7470-47d2-a645-d2e214decc39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ec133074-98d6-4b52-919c-f4b58aedb485"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSDA"",
                    ""id"": ""c808f8b0-4769-4f52-ba80-233a1f65a034"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""da5c0e26-a1e3-4d44-9cab-e609c5001756"",
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
                    ""id"": ""12abdf3f-e4c1-40f6-a14b-61d00ba096f8"",
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
                    ""id"": ""3c178e39-a906-4a99-b547-4dd308b0935e"",
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
                    ""id"": ""5a51ff07-1e2d-4b93-bcc8-5b7d9e2f754b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""↑↓→←"",
                    ""id"": ""84c4c009-f283-4e85-9e7d-c3411b8d7f98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bfe68b8a-dd14-436b-a44f-3438236744c0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3d82cf43-cc35-41ee-a6e9-39ae6b8241b7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33472772-c74e-49d0-aef1-7c0d96a65032"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3180234f-2ba2-4dab-8146-9269d7b82022"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4b6fe535-835e-4af8-bb64-8873daba75c8"",
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
                    ""id"": ""8499b754-7b77-4944-8f63-1f4e03960ce0"",
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
                    ""id"": ""925d5e55-b82d-4741-89a1-7446e5e8981b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eea44ca4-c55f-4f47-9f58-6df4fd47d708"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""052d4181-1835-4a8d-b465-685075bdc835"",
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
                    ""id"": ""aca0681e-4840-446d-af62-726001c039d3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerKeebordInput
        m_PlayerKeebordInput = asset.FindActionMap("PlayerKeebordInput", throwIfNotFound: true);
        m_PlayerKeebordInput_Movement = m_PlayerKeebordInput.FindAction("Movement", throwIfNotFound: true);
        m_PlayerKeebordInput_Sprint = m_PlayerKeebordInput.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerKeebordInput_Jump = m_PlayerKeebordInput.FindAction("Jump", throwIfNotFound: true);
        m_PlayerKeebordInput_Use = m_PlayerKeebordInput.FindAction("Use", throwIfNotFound: true);
        m_PlayerKeebordInput_Crouch = m_PlayerKeebordInput.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerKeebordInput_Aim = m_PlayerKeebordInput.FindAction("Aim", throwIfNotFound: true);
        m_PlayerKeebordInput_Fire = m_PlayerKeebordInput.FindAction("Fire", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerKeebordInput
    private readonly InputActionMap m_PlayerKeebordInput;
    private List<IPlayerKeebordInputActions> m_PlayerKeebordInputActionsCallbackInterfaces = new List<IPlayerKeebordInputActions>();
    private readonly InputAction m_PlayerKeebordInput_Movement;
    private readonly InputAction m_PlayerKeebordInput_Sprint;
    private readonly InputAction m_PlayerKeebordInput_Jump;
    private readonly InputAction m_PlayerKeebordInput_Use;
    private readonly InputAction m_PlayerKeebordInput_Crouch;
    private readonly InputAction m_PlayerKeebordInput_Aim;
    private readonly InputAction m_PlayerKeebordInput_Fire;
    public struct PlayerKeebordInputActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerKeebordInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerKeebordInput_Movement;
        public InputAction @Sprint => m_Wrapper.m_PlayerKeebordInput_Sprint;
        public InputAction @Jump => m_Wrapper.m_PlayerKeebordInput_Jump;
        public InputAction @Use => m_Wrapper.m_PlayerKeebordInput_Use;
        public InputAction @Crouch => m_Wrapper.m_PlayerKeebordInput_Crouch;
        public InputAction @Aim => m_Wrapper.m_PlayerKeebordInput_Aim;
        public InputAction @Fire => m_Wrapper.m_PlayerKeebordInput_Fire;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKeebordInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKeebordInputActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerKeebordInputActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerKeebordInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerKeebordInputActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Use.started += instance.OnUse;
            @Use.performed += instance.OnUse;
            @Use.canceled += instance.OnUse;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
        }

        private void UnregisterCallbacks(IPlayerKeebordInputActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Use.started -= instance.OnUse;
            @Use.performed -= instance.OnUse;
            @Use.canceled -= instance.OnUse;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
        }

        public void RemoveCallbacks(IPlayerKeebordInputActions instance)
        {
            if (m_Wrapper.m_PlayerKeebordInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerKeebordInputActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerKeebordInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerKeebordInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerKeebordInputActions @PlayerKeebordInput => new PlayerKeebordInputActions(this);
    public interface IPlayerKeebordInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
