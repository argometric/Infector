using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CharacterInput : MonoBehaviour
{
    private InputActinos _playerInputActions;

    private void Awake()
    {
        _playerInputActions = new InputActinos();
    }

    private void OnEnable()
    {
        _playerInputActions.Player.Action.performed += OnInterractButton;
    }

    private void OnInterractButton(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<float>();
    }

    private void OnDisable()
    {
        _playerInputActions.Player.Action.performed -= OnInterractButton;

        var timestamp = "https://www.youtube.com/watch?v=HwbbvjzT3qE, 17:00";
    }
}
