using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Battler : MonoBehaviour
{
    [SerializeField] int playerHp;
    [SerializeField] TextMeshProUGUI playerTextObject;
    [SerializeField] BattlerHand hand;

    // Start is called before the first frame update
    void Start()
    {
        playerHp=200;
    }

    // Update is called once per frame
    void Update()
    {
        playerTextObject.text=""+playerHp;
    }
    public BattlerHand Hand { get => hand; }

    public void SetCardToHand(Card card){
        hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card){
        Debug.Log(card.Base.name);
    }
}
