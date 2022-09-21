using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator CardGenerator;
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
        SendCardsTo(player,-80);
        SendCardsTo(enemy,80);

    }
    void SendCardsTo(Battler battler,int y){
        for (int i = 0; i < 2; i++)
        {
            Card card = CardGenerator.Spawn(i,y);
            battler.Hand.Add(card);
        }
    }
}
