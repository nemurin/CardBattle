using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI turnResultText;
    [SerializeField] TextMeshProUGUI playerLifeText;
    [SerializeField] TextMeshProUGUI enemyLifeText;
    public void Init(){
        turnResultText.gameObject.SetActive(false);
    }
    public void ShowLifes(int playerLife, int enemyLife){
        playerLifeText.text = ""+playerLife;
        enemyLifeText.text = ""+enemyLife;
    }

    //勝敗表示
    public void ShowTurnResult(string result){
        turnResultText.gameObject.SetActive(true);
        turnResultText.text = result;
    }
}
