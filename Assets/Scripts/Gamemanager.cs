using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    private static Gamemanager i;
    private InputController inputController;
    private bool CheckFirstJoin = true;
    public bool CheckFirstName = true;
    public static Gamemanager I
    {
        get
        {
            if (null == i)
            {
                return null;
            }
            return i;
        }
    }

    public string playerName;
    public string PlayerName
    {
        get { return playerName; }
    }


    public string selectCr;
    public string SelectCr
    {
            get { return selectCr; }
    }

    private void Awake()
    {
        if (i == null)
        {
            i = this;

            DontDestroyOnLoad(this.gameObject); // ���� �Ѿ�� �ı����� �ʰ� ����
        }
        else
        {
            Destroy(this.gameObject); // ���ӸŴ��� ������Ʈ�� 2���ϰ�� ���߿� ������� ���ӸŴ��� ������Ʈ�� �ı�
        }
        inputController = FindObjectOfType<InputController>();
    }


    public void SetPlayerName(string newName)
    {
        if (newName != "")
        {
            playerName = newName;
        }
    }

    public void ScreenChange(int i)
    {
        switch(i)
        {
            case 1:
                if (playerName != "")
                {
                    SceneManager.LoadScene("3");
                }
                else
                {
                    Debug.Log("�Էµ� �̸��� �����ϴ�.");
                }
           break;

            case 2:
                if(CheckFirstJoin==true) 
                {
                    SceneManager.LoadScene("2");
                    CheckFirstJoin = false;
                }
                else
                {
                    Debug.Log("ù ���������� �ƴ�");
                }
                break;

        }

    }
}
