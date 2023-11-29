using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{ // 플레이어 오브젝트의 Transform을 연결
    private TextMeshProUGUI NameText;
    private void Start()
    {
        NameText = GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    { 
            NameText.text =  "Name :" + Gamemanager.I.playerName; // 게임매니저에 저장된 이름 가져오기
    }
}
