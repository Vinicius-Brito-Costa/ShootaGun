// GENERATED AUTOMATICALLY FROM 'Assets/Global/Configs/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""674c945f-0db1-4bac-9a7e-f5b33f2fd04e"",
            ""actions"": [
                {
                    ""name"": ""D-Pad Up"",
                    ""type"": ""Button"",
                    ""id"": ""49b084c6-a51a-444e-9bf7-9b6e2164934b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D-Pad Down"",
                    ""type"": ""Button"",
                    ""id"": ""af588bbe-32db-4cb1-a86d-b43b6e56bbc6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D-Pad Left"",
                    ""type"": ""Button"",
                    ""id"": ""49e0bc03-48ea-4c9e-9091-dbe668f71e98"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D-Pad Right"",
                    ""type"": ""Button"",
                    ""id"": ""5de55d0d-51e0-4ea4-a9d4-6fa875ece409"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analog Left"",
                    ""type"": ""Button"",
                    ""id"": ""ec9bcce1-f42d-43ae-b09f-b180e9d818f6"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analog Left Click"",
                    ""type"": ""Button"",
                    ""id"": ""a2a9588e-760b-46cb-b539-2a6975de2ca0"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analog Right"",
                    ""type"": ""Button"",
                    ""id"": ""3067c5f5-f1f1-4013-8b97-eb6c5f8d49c6"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone(max=0.25)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analog Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""48e88e56-ac46-475d-ba20-883744e8ee2f"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""c7a92986-0a5b-48ad-a995-b7b62833f014"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""d1d2bae8-60b0-4a0b-a7b6-23eb2a0ccb30"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""87f9229e-fb18-4763-8446-d1e01bf25321"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""00a0d4b6-5a55-4faf-8178-805086ac6978"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""62a86feb-c487-4b0d-8547-d7efb2c2ec24"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""927701bf-8a37-4b94-b5be-a45739fcf15f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Trigger 1"",
                    ""type"": ""Button"",
                    ""id"": ""9b15ddb7-5d68-40b1-b69c-211749df51a7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Trigger 2"",
                    ""type"": ""Button"",
                    ""id"": ""51c73ae3-7723-4edd-88d2-1d6e4d75d30f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Trigger 1"",
                    ""type"": ""Button"",
                    ""id"": ""ab2d734c-ee61-4c49-8e1a-855cea00babc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Trigger 2"",
                    ""type"": ""Button"",
                    ""id"": ""4cdb2e96-f3ab-462f-a567-8d7260ab4de9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""9a691bda-063c-4f38-a416-698b264c1f21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Button"",
                    ""id"": ""857327a5-a8c5-42ea-8162-37454470d181"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""51bbf864-6c7e-4f15-8219-11b0f48346c9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb6a6f85-2e40-448f-97bb-22b14314ffa5"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87b06d87-8b61-4969-99ef-37b3a894562b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfa9af44-8a6c-427c-bef5-008372833eb4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0603238f-bd2b-4300-a918-a5484394fb48"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2448cb74-d200-4f9f-bfde-0275a45c47fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1db5fb6d-6ce1-4037-9884-ee51c4ab43db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b0ba7ac8-a545-423f-b050-0801b4313f98"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c10cb542-6ce1-443d-a042-6642d26ac752"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a4d63e48-d4b1-467a-bb1c-bb01788862d6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""a9a78c3a-43dc-4645-9e6a-fc5f1ea0a805"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3cc53eb2-03d5-4af8-8af0-6b6ea78b4cc3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8c433c00-9caa-4294-a7a5-f8c46ac4c1d2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""829f9204-cb18-460e-8ca0-333e738f87a3"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b32e0ad7-d694-443b-9d76-a049cec28e65"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2e7f5fbd-49f1-4b0c-9fe3-5df0cdd74b47"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7fc562d-dcc1-49f8-9699-134fb322b87c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6393cec-1f94-4617-9491-ed37ba3e63f2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""562c3a96-aaa2-467d-aa81-a4eba152ee14"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado e Mouse + GamePad"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16a95c46-537c-4222-88e2-65f4d897e956"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado e Mouse + GamePad"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa29ba6d-b861-4558-a7e5-f5a0130e09e2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a946d7ab-7400-4c5f-b4a8-42404b737aa1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""425c1b75-f8ac-4e44-841e-5f1bf861975b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5495a78-5634-4107-93e5-b15944e90831"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82d51860-e6f2-48e9-992f-e8e326fac510"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871bf24f-2d93-4e92-a7fa-f9baf46d12b7"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43ae6d08-172f-4641-8b6c-7f32bfc58fbf"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a073142d-21a7-4cc7-997d-cc1e73e9b951"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77132ef7-67b8-4937-81f0-feb7a2bbd28f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acb23126-68e0-4c34-a43a-e472df6e689d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f95c9487-7b4f-4b13-8a6d-f266de004bb0"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c22e0a22-88dc-4674-b7e9-8c7919c0d45e"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81eeaba8-bdc7-4d27-9241-50802a2ca928"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6965ab7-8f10-40b0-8831-f0114336e94a"",
                    ""path"": ""<Pointer>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Teclado e Mouse + GamePad"",
            ""bindingGroup"": ""Teclado e Mouse + GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_DPadUp = m_Gameplay.FindAction("D-Pad Up", throwIfNotFound: true);
        m_Gameplay_DPadDown = m_Gameplay.FindAction("D-Pad Down", throwIfNotFound: true);
        m_Gameplay_DPadLeft = m_Gameplay.FindAction("D-Pad Left", throwIfNotFound: true);
        m_Gameplay_DPadRight = m_Gameplay.FindAction("D-Pad Right", throwIfNotFound: true);
        m_Gameplay_AnalogLeft = m_Gameplay.FindAction("Analog Left", throwIfNotFound: true);
        m_Gameplay_AnalogLeftClick = m_Gameplay.FindAction("Analog Left Click", throwIfNotFound: true);
        m_Gameplay_AnalogRight = m_Gameplay.FindAction("Analog Right", throwIfNotFound: true);
        m_Gameplay_AnalogRightClick = m_Gameplay.FindAction("Analog Right Click", throwIfNotFound: true);
        m_Gameplay_X = m_Gameplay.FindAction("X", throwIfNotFound: true);
        m_Gameplay_Y = m_Gameplay.FindAction("Y", throwIfNotFound: true);
        m_Gameplay_A = m_Gameplay.FindAction("A", throwIfNotFound: true);
        m_Gameplay_B = m_Gameplay.FindAction("B", throwIfNotFound: true);
        m_Gameplay_Start = m_Gameplay.FindAction("Start", throwIfNotFound: true);
        m_Gameplay_Select = m_Gameplay.FindAction("Select", throwIfNotFound: true);
        m_Gameplay_LeftTrigger1 = m_Gameplay.FindAction("Left Trigger 1", throwIfNotFound: true);
        m_Gameplay_LeftTrigger2 = m_Gameplay.FindAction("Left Trigger 2", throwIfNotFound: true);
        m_Gameplay_RightTrigger1 = m_Gameplay.FindAction("Right Trigger 1", throwIfNotFound: true);
        m_Gameplay_RightTrigger2 = m_Gameplay.FindAction("Right Trigger 2", throwIfNotFound: true);
        m_Gameplay_Space = m_Gameplay.FindAction("Space", throwIfNotFound: true);
        m_Gameplay_Mouse = m_Gameplay.FindAction("Mouse", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_DPadUp;
    private readonly InputAction m_Gameplay_DPadDown;
    private readonly InputAction m_Gameplay_DPadLeft;
    private readonly InputAction m_Gameplay_DPadRight;
    private readonly InputAction m_Gameplay_AnalogLeft;
    private readonly InputAction m_Gameplay_AnalogLeftClick;
    private readonly InputAction m_Gameplay_AnalogRight;
    private readonly InputAction m_Gameplay_AnalogRightClick;
    private readonly InputAction m_Gameplay_X;
    private readonly InputAction m_Gameplay_Y;
    private readonly InputAction m_Gameplay_A;
    private readonly InputAction m_Gameplay_B;
    private readonly InputAction m_Gameplay_Start;
    private readonly InputAction m_Gameplay_Select;
    private readonly InputAction m_Gameplay_LeftTrigger1;
    private readonly InputAction m_Gameplay_LeftTrigger2;
    private readonly InputAction m_Gameplay_RightTrigger1;
    private readonly InputAction m_Gameplay_RightTrigger2;
    private readonly InputAction m_Gameplay_Space;
    private readonly InputAction m_Gameplay_Mouse;
    public struct GameplayActions
    {
        private @Controller m_Wrapper;
        public GameplayActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPadUp => m_Wrapper.m_Gameplay_DPadUp;
        public InputAction @DPadDown => m_Wrapper.m_Gameplay_DPadDown;
        public InputAction @DPadLeft => m_Wrapper.m_Gameplay_DPadLeft;
        public InputAction @DPadRight => m_Wrapper.m_Gameplay_DPadRight;
        public InputAction @AnalogLeft => m_Wrapper.m_Gameplay_AnalogLeft;
        public InputAction @AnalogLeftClick => m_Wrapper.m_Gameplay_AnalogLeftClick;
        public InputAction @AnalogRight => m_Wrapper.m_Gameplay_AnalogRight;
        public InputAction @AnalogRightClick => m_Wrapper.m_Gameplay_AnalogRightClick;
        public InputAction @X => m_Wrapper.m_Gameplay_X;
        public InputAction @Y => m_Wrapper.m_Gameplay_Y;
        public InputAction @A => m_Wrapper.m_Gameplay_A;
        public InputAction @B => m_Wrapper.m_Gameplay_B;
        public InputAction @Start => m_Wrapper.m_Gameplay_Start;
        public InputAction @Select => m_Wrapper.m_Gameplay_Select;
        public InputAction @LeftTrigger1 => m_Wrapper.m_Gameplay_LeftTrigger1;
        public InputAction @LeftTrigger2 => m_Wrapper.m_Gameplay_LeftTrigger2;
        public InputAction @RightTrigger1 => m_Wrapper.m_Gameplay_RightTrigger1;
        public InputAction @RightTrigger2 => m_Wrapper.m_Gameplay_RightTrigger2;
        public InputAction @Space => m_Wrapper.m_Gameplay_Space;
        public InputAction @Mouse => m_Wrapper.m_Gameplay_Mouse;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @DPadUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadUp;
                @DPadDown.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadDown;
                @DPadLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadLeft;
                @DPadRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDPadRight;
                @AnalogLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeft;
                @AnalogLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeft;
                @AnalogLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeft;
                @AnalogLeftClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeftClick;
                @AnalogLeftClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeftClick;
                @AnalogLeftClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogLeftClick;
                @AnalogRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRight;
                @AnalogRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRight;
                @AnalogRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRight;
                @AnalogRightClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRightClick;
                @AnalogRightClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRightClick;
                @AnalogRightClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAnalogRightClick;
                @X.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @A.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @Start.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @LeftTrigger1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger1;
                @LeftTrigger1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger1;
                @LeftTrigger1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger1;
                @LeftTrigger2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger2;
                @LeftTrigger2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger2;
                @LeftTrigger2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftTrigger2;
                @RightTrigger1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger1;
                @RightTrigger1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger1;
                @RightTrigger1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger1;
                @RightTrigger2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger2;
                @RightTrigger2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger2;
                @RightTrigger2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightTrigger2;
                @Space.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Mouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @AnalogLeft.started += instance.OnAnalogLeft;
                @AnalogLeft.performed += instance.OnAnalogLeft;
                @AnalogLeft.canceled += instance.OnAnalogLeft;
                @AnalogLeftClick.started += instance.OnAnalogLeftClick;
                @AnalogLeftClick.performed += instance.OnAnalogLeftClick;
                @AnalogLeftClick.canceled += instance.OnAnalogLeftClick;
                @AnalogRight.started += instance.OnAnalogRight;
                @AnalogRight.performed += instance.OnAnalogRight;
                @AnalogRight.canceled += instance.OnAnalogRight;
                @AnalogRightClick.started += instance.OnAnalogRightClick;
                @AnalogRightClick.performed += instance.OnAnalogRightClick;
                @AnalogRightClick.canceled += instance.OnAnalogRightClick;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @LeftTrigger1.started += instance.OnLeftTrigger1;
                @LeftTrigger1.performed += instance.OnLeftTrigger1;
                @LeftTrigger1.canceled += instance.OnLeftTrigger1;
                @LeftTrigger2.started += instance.OnLeftTrigger2;
                @LeftTrigger2.performed += instance.OnLeftTrigger2;
                @LeftTrigger2.canceled += instance.OnLeftTrigger2;
                @RightTrigger1.started += instance.OnRightTrigger1;
                @RightTrigger1.performed += instance.OnRightTrigger1;
                @RightTrigger1.canceled += instance.OnRightTrigger1;
                @RightTrigger2.started += instance.OnRightTrigger2;
                @RightTrigger2.performed += instance.OnRightTrigger2;
                @RightTrigger2.canceled += instance.OnRightTrigger2;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_TecladoeMouseGamePadSchemeIndex = -1;
    public InputControlScheme TecladoeMouseGamePadScheme
    {
        get
        {
            if (m_TecladoeMouseGamePadSchemeIndex == -1) m_TecladoeMouseGamePadSchemeIndex = asset.FindControlSchemeIndex("Teclado e Mouse + GamePad");
            return asset.controlSchemes[m_TecladoeMouseGamePadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnAnalogLeft(InputAction.CallbackContext context);
        void OnAnalogLeftClick(InputAction.CallbackContext context);
        void OnAnalogRight(InputAction.CallbackContext context);
        void OnAnalogRightClick(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnLeftTrigger1(InputAction.CallbackContext context);
        void OnLeftTrigger2(InputAction.CallbackContext context);
        void OnRightTrigger1(InputAction.CallbackContext context);
        void OnRightTrigger2(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
    }
}
