using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Battler : MonoBehaviour
{
    [SerializeField] int playerHp;
    [SerializeField] long don;
    [SerializeField] TextMeshProUGUI playerTextObject;
    [SerializeField] BattlerHand hand;
    [SerializeField] SubmitPosition SubmitPosition;
    public UnityAction OnSubmitAction;
    public bool isSubmitted;
    public int Life;

    // Start is called before the first frame update
    void Start()
    {
        playerHp=200;
        don=2;
    }

    // Update is called once per frame
    void Update()
    {
        playerTextObject.text=""+playerHp+"DON"+don;
    }
    public BattlerHand Hand { get => hand; }
    public Card SubmitCard {get=>SubmitPosition.SubmitCard;}

    public void SetCardToHand(Card card){
        hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card){
        if(isSubmitted)return;
        if(don>0){
        SubmitPosition.Set(card);
        hand.Remove(card);
        Debug.Log(card.Base.name);
        don=don-card.cost;
        }
    }
    public void OnSubmitButton(){
        // GameMasterに通知
        isSubmitted=true;
        OnSubmitAction?.Invoke();
    }
    public void RandomSubmit(){
        //手札からランダムでカードを抜き取る
        Card card = hand.RandomRemove();
        SubmitPosition.Set(card);
        isSubmitted=true;
        OnSubmitAction?.Invoke();
    }
    public void SetupNextTurn(){
        SubmitPosition.DeleteCard();
        isSubmitted=false;
    }
}
