using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Btn : MonoBehaviour
{
    public TMP_InputField OpenRenameBox;
    public Canvas ChoiceBox;

    public void OpenUiRename()
    { 
        Time.timeScale = 0f;
        OpenRenameBox.text = "Input Your New Name!";
        OpenRenameBox.gameObject.SetActive(true);
    }
    
    public void ChoiceKnight()
    {
        Debug.Log("OpenChoiceBox called");
        Gamemanager.I.selectCr = "Knight";
        ChoiceBox.gameObject.SetActive(false);
        Gamemanager.I.ScreenChange(2);
    }
    public void ChoiceElf()
    {
        Debug.Log("¿¤ÇÁ");
        Gamemanager.I.selectCr = "Elf";
        ChoiceBox.gameObject.SetActive(false);
        Gamemanager.I.ScreenChange(2);
    }

    public void OpenChoiceBox()
    {
        ChoiceBox.gameObject.SetActive(true);
    }
}
