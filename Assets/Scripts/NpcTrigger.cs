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
        Debug.Log("트리거 충돌 확인");
        npcTextUi.SetActive(true);
        Time.timeScale = 0f;
    }
    void OnTriggerExit2D(Collider2D cllision)
    {
        isFirst = false;
        Debug.Log("트리거 충돌 종료");
        npcTextUi.SetActive(false);
    }
}
