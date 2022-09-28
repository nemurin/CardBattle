using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator CardGenerator;
    [SerializeField] GameObject submitButton;
    RuleBook ruleBook;
    public void Awake(){
        ruleBook = GetComponent<RuleBook>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //カードを生成して配る
    void Setup(){
        player.OnSubmitAction = SubmittedAction;
        enemy.OnSubmitAction = SubmittedAction;
        SendCardsTo(player,-80);
        SendCardsTo(enemy,80);

    }
    void SubmittedAction(){
        if(player.isSubmitted && enemy.isSubmitted){
            submitButton.SetActive(false);
            StartCoroutine(CardsBattle());
            }
        else if(player.isSubmitted){
            submitButton.SetActive(false);
            enemy.RandomSubmit();
            }
    }
    void SendCardsTo(Battler battler,int y){
        for (int i = 0; i < 2; i++)
        {
            Card card = CardGenerator.Spawn(i,y);
            battler.SetCardToHand(card);
        }
    }
    //勝利判定
    IEnumerator CardsBattle(){
        yield return new WaitForSeconds(1f);
        Result result = ruleBook.GetResult(player,enemy);
        SetupNextTurn();
    }
    void SetupNextTurn(){
        player.SetupNextTurn();
        enemy.SetupNextTurn();
        submitButton.SetActive(true);
    }
}
