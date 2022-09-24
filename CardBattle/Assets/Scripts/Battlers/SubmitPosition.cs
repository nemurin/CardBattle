using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //選択されたカードを管理する
    Card submitCard;
    public Card SubmitCard {get => submitCard;}
    public void Set(Card card){
        submitCard =card;
        card.transform.SetParent(transform);
        card.transform.position = transform.position;
    }
}
