using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UserList : MonoBehaviour
{
    private GameObject player;
    private List<GameObject> userList;
    private TextMeshPro playerNamePlate;
    private TextMeshProUGUI playerText;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        userList = new List<GameObject>();
        userList.AddRange(GameObject.FindGameObjectsWithTag("NPC"));
        playerText = GetComponentInChildren<TextMeshProUGUI>();
        playerNamePlate = player.GetComponentInChildren<TextMeshPro>();
    }

    private void Start()
    {
        playerText.text = playerNamePlate.text;

        float posY = 440;
        for(int i = 0; i < userList.Count; i++)
        {
            posY -= 40;
            TextMeshPro npcNamePlate = userList[i].GetComponentInChildren<TextMeshPro>();
            TextMeshProUGUI npcText = Instantiate(playerText);            
            npcText.rectTransform.position = new Vector3(0, posY, 0);
            npcText.text = npcNamePlate.text;
            npcText.transform.SetParent(this.transform, false);
        }
    }
}
