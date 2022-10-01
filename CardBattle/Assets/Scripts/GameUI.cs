using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI turnResultText;
    public void Init(){
        turnResultText.gameObject.SetActive(false);
    }

    //勝敗表示
    public void ShowTurnResult(string result){
        turnResultText.gameObject.SetActive(true);
        turnResultText.text = result;
    }
}
