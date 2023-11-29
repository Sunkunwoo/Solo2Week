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

            DontDestroyOnLoad(this.gameObject); // 씬이 넘어가도 파괴되지 않게 설정
        }
        else
        {
            Destroy(this.gameObject); // 게임매니저 오브젝트가 2개일경우 나중에 만들어진 게임매니저 오브젝트를 파괴
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
                    Debug.Log("입력된 이름이 없습니다.");
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
                    Debug.Log("첫 직업선택이 아님");
                }
                break;

        }

    }
}
