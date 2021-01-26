// GENERATED AUTOMATICALLY FROM 'Assets/Data/Input File/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""ThirdPerson"",
            ""id"": ""d69a5f07-99b6-4d85-8040-c5d2c8deb5c3"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""Value"",
                    ""id"": ""53bbad48-fb3c-487a-a97f-b6555e3fc211"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jumps"",
                    ""type"": ""Button"",
                    ""id"": ""59d0d3e2-c5a8-4d6f-bbb4-c99c113a448d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""1f294cb8-114c-4b67-a6c8-80fdded94e88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f8b6a19b-6a46-4fac-b234-c95d204fee74"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumps"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6bd66a1b-5274-4500-b13a-1cc2931059a8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""142e58bc-dccb-4105-a799-c1739bad4266"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d26bf4d5-5554-4e15-ad08-edb0267c19bf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7030936c-2fc0-48b1-b57b-7a20a3346ea3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""addb8f5e-458b-4c63-8a74-feacb5528649"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7acea255-aa96-4993-a759-cc3dcc6dad9b"",
                    ""path"": """",
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
        // ThirdPerson
        m_ThirdPerson = asset.FindActionMap("ThirdPerson", throwIfNotFound: true);
        m_ThirdPerson_Movements = m_ThirdPerson.FindAction("Movements", throwIfNotFound: true);
        m_ThirdPerson_Jumps = m_ThirdPerson.FindAction("Jumps", throwIfNotFound: true);
        m_ThirdPerson_Fire = m_ThirdPerson.FindAction("Fire", throwIfNotFound: true);
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

    // ThirdPerson
    private readonly InputActionMap m_ThirdPerson;
    private IThirdPersonActions m_ThirdPersonActionsCallbackInterface;
    private readonly InputAction m_ThirdPerson_Movements;
    private readonly InputAction m_ThirdPerson_Jumps;
    private readonly InputAction m_ThirdPerson_Fire;
    public struct ThirdPersonActions
    {
        private @GameInputActions m_Wrapper;
        public ThirdPersonActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_ThirdPerson_Movements;
        public InputAction @Jumps => m_Wrapper.m_ThirdPerson_Jumps;
        public InputAction @Fire => m_Wrapper.m_ThirdPerson_Fire;
        public InputActionMap Get() { return m_Wrapper.m_ThirdPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThirdPersonActions set) { return set.Get(); }
        public void SetCallbacks(IThirdPersonActions instance)
        {
            if (m_Wrapper.m_ThirdPersonActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovements;
                @Jumps.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJumps;
                @Jumps.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJumps;
                @Jumps.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJumps;
                @Fire.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_ThirdPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @Jumps.started += instance.OnJumps;
                @Jumps.performed += instance.OnJumps;
                @Jumps.canceled += instance.OnJumps;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public ThirdPersonActions @ThirdPerson => new ThirdPersonActions(this);
    public interface IThirdPersonActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnJumps(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
