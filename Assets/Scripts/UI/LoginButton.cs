using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoginButton : MonoBehaviour
{
    private GameObject login;
    private InputField inputField;
    private TextMeshProUGUI idText;
    private string inputText;

    private void Awake()
    {
        login = GameObject.Find("LoginUI");
        inputField = GetComponentInChildren<InputField>();
        idText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void ButtonClick()
    {
        inputText = inputField.text;
        int length = inputText.Length;
        if (length < 2 || length > 10) return;

        idText.text = inputText;
        login.gameObject.SetActive(false);
    }
}
