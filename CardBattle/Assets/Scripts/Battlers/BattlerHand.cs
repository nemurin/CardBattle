using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlerHand : MonoBehaviour
{
    public List<Card> list = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Add(Card card){
        list.Add(card);
    }
    public void Remove(Card card){
        list.Remove(card);
    }
    public Card RandomRemove(){
        int r = Random.Range(0,list.Count);
        Card card = list[r];
        Remove(card);
        return card;
    }
}
