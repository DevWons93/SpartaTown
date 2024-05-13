using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBar : MonoBehaviour
{
    [SerializeField] private GameObject loginPanel;    

    public void ButtonClick()
    {        
        this.gameObject.SetActive(false);
        loginPanel.SetActive(true);
    }
}
