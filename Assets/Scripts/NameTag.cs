using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{ // �÷��̾� ������Ʈ�� Transform�� ����
    private TextMeshProUGUI NameText;
    private void Start()
    {
        NameText = GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    { 
            NameText.text =  "Name :" + Gamemanager.I.playerName; // ���ӸŴ����� ����� �̸� ��������
    }
}
