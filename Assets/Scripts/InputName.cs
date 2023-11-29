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
        Gamemanager.I.SetPlayerName(newName); // �Էµ� �� ���ӸŴ����� ����
        if (Gamemanager.I.playerName != "")
        {
            if(Gamemanager.I.CheckFirstName == true)
            {
                Gamemanager.I.ScreenChange(1);
                Gamemanager.I.CheckFirstName = false;
            }
            nameInput.gameObject.SetActive(false); // �Է�â ��Ȱ��ȭ
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
