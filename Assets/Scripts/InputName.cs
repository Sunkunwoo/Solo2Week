using UnityEngine;
using TMPro;

public class InputName : MonoBehaviour
{
    private TMP_InputField nameInput;

    private void Start()
    {
        nameInput = GetComponentInChildren<TMP_InputField>();
    }

    public void SaveName()
    {
        string newName = nameInput.text;
        Gamemanager.I.SetPlayerName(newName); // 입력된 값 게임매니저에 저장
        if (Gamemanager.I.playerName != "")
        {
            if(Gamemanager.I.CheckFirstName == true)
            {
                Gamemanager.I.ScreenChange(1);
                Gamemanager.I.CheckFirstName = false;
            }
            nameInput.gameObject.SetActive(false); // 입력창 비활성화
        }
        Time.timeScale = 1f;
    }

    public void OnClick()
    {
        nameInput.text = "";
    }

    public void OnDeselect()
    {
        nameInput.text = Gamemanager.I.playerName;
        //Time.timeScale = 1f;
    }
}
