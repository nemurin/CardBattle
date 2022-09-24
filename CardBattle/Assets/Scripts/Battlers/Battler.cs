using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Battler : MonoBehaviour
{
    [SerializeField] int playerHp;
    [SerializeField] long don;
    [SerializeField] TextMeshProUGUI playerTextObject;
    [SerializeField] BattlerHand hand;
    [SerializeField] SubmitPosition SubmitPosition;

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

    public void SetCardToHand(Card card){
        hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card){
        if(don>0){
        SubmitPosition.Set(card);
        hand.Remove(card);
        Debug.Log(card.Base.name);
        don=don-card.cost;
        }
    }
}
