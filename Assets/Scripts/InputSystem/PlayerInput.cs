//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/InputSystem/PlayerInput.inputactions
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
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Tanks"",
            ""id"": ""3b9517ad-10c9-40d0-9145-de4502308b4a"",
            ""actions"": [
                {
                    ""name"": ""LeftMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bad98377-b81d-40b3-a99d-8bd0d2c8772a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4dae0fc8-532c-4172-9e38-cf7a338bcd1c"",
                    ""expectedControlType"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ba1c8e8b-f6df-4061-a202-5df23b6e0cb0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""94e74160-5e8c-4150-a22f-d964e1223ca6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""fbfbd7cf-f624-4a25-adcb-a7bf532b12f0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""b200cda1-8695-4dd9-b16c-0f6b2539321f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""a1fd02e5-18c1-4a4c-be4e-bce7d3dce43d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cad219d8-a1ab-4c0f-8828-36f927450b61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""abe78eef-7fa2-4534-9522-d6aaa91642ac"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cca4925a-1067-4d72-b5fa-c199bac10888"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ff013f5-aee3-40ab-8798-ae95db80964e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1fab7b29-a036-47d0-a770-dcb303ac5710"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tanks
        m_Tanks = asset.FindActionMap("Tanks", throwIfNotFound: true);
        m_Tanks_LeftMove = m_Tanks.FindAction("LeftMove", throwIfNotFound: true);
        m_Tanks_RightMove = m_Tanks.FindAction("RightMove", throwIfNotFound: true);
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

    // Tanks
    private readonly InputActionMap m_Tanks;
    private List<ITanksActions> m_TanksActionsCallbackInterfaces = new List<ITanksActions>();
    private readonly InputAction m_Tanks_LeftMove;
    private readonly InputAction m_Tanks_RightMove;
    public struct TanksActions
    {
        private @PlayerInput m_Wrapper;
        public TanksActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftMove => m_Wrapper.m_Tanks_LeftMove;
        public InputAction @RightMove => m_Wrapper.m_Tanks_RightMove;
        public InputActionMap Get() { return m_Wrapper.m_Tanks; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TanksActions set) { return set.Get(); }
        public void AddCallbacks(ITanksActions instance)
        {
            if (instance == null || m_Wrapper.m_TanksActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TanksActionsCallbackInterfaces.Add(instance);
            @LeftMove.started += instance.OnLeftMove;
            @LeftMove.performed += instance.OnLeftMove;
            @LeftMove.canceled += instance.OnLeftMove;
            @RightMove.started += instance.OnRightMove;
            @RightMove.performed += instance.OnRightMove;
            @RightMove.canceled += instance.OnRightMove;
        }

        private void UnregisterCallbacks(ITanksActions instance)
        {
            @LeftMove.started -= instance.OnLeftMove;
            @LeftMove.performed -= instance.OnLeftMove;
            @LeftMove.canceled -= instance.OnLeftMove;
            @RightMove.started -= instance.OnRightMove;
            @RightMove.performed -= instance.OnRightMove;
            @RightMove.canceled -= instance.OnRightMove;
        }

        public void RemoveCallbacks(ITanksActions instance)
        {
            if (m_Wrapper.m_TanksActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITanksActions instance)
        {
            foreach (var item in m_Wrapper.m_TanksActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TanksActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TanksActions @Tanks => new TanksActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface ITanksActions
    {
        void OnLeftMove(InputAction.CallbackContext context);
        void OnRightMove(InputAction.CallbackContext context);
    }
}