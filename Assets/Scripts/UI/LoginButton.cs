using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoginButton : MonoBehaviour
{
    [SerializeField] private GameObject menuBar;

    private GameObject player;    
    private InputField inputField;
    private TextMeshProUGUI idText;    

    private void Awake()
    {
        player = GameObject.Find("Player");        
        inputField = GetComponentInChildren<InputField>();
        idText = player.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void ButtonClick()
    {
        string inputText = inputField.text;
        int length = inputText.Length;
        if (length < 2 || length > 10) return;

        idText.text = inputText;
        this.gameObject.SetActive(false);
        menuBar.SetActive(true);
    }    
}
