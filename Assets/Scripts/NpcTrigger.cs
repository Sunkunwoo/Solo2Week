using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcTrigger : MonoBehaviour
{
    bool isFirst = true;
    public GameObject npcTextUi;
    public TextMeshProUGUI resetText;

    void OnTriggerEnter2D(Collider2D cllision)
    {
        if (isFirst == false)
        {
            resetText.text = "Well Come!";
        }
        Debug.Log("Ʈ���� �浹 Ȯ��");
        npcTextUi.SetActive(true);
        Time.timeScale = 0f;
    }
    void OnTriggerExit2D(Collider2D cllision)
    {
        isFirst = false;
        Debug.Log("Ʈ���� �浹 ����");
        npcTextUi.SetActive(false);
    }
}
