using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcTextChange : MonoBehaviour
{
    public TextMeshProUGUI npcTxt;
    public GameObject npcTextUi;
    // Update is called once per frame
    public void Txt1()
    {
        npcTxt.text= "You Click Text1 Btn!";
    }
    public void Txt2()
    {
        npcTxt.text = "You Click Text2 Btn!";
    }
    public void Exit()
    {
        if (Time.timeScale == 0f)
        {
            npcTxt.text = "GoodBye!";
            Time.timeScale = 1f;
        }
        else
        {
            npcTextUi.SetActive(false);
        }
    }
}
