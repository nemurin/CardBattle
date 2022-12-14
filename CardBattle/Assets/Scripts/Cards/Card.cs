using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //名前
    [SerializeField] public string name;
    //カテゴリ
    [SerializeField] public string category;
    //属性
    [SerializeField] public string type;
    //パワー
    [SerializeField] public long power;
    //コスト
    [SerializeField] public long cost;
    //絵
    [SerializeField] public Image icon;
    //効果説明
    [TextArea]
    [SerializeField] public string description;

    public CardBase Base{get; private set;}

    public UnityAction<Card> OnClickCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Set(CardBase cardBase){
        Base = cardBase;
        icon.sprite=cardBase.icon;
        name = cardBase.name;
        category = cardBase.category;
        type = cardBase.type;
        power = cardBase.power;
        cost = cardBase.cost;
        description = cardBase.description;
    }
    public void OnClick(){
        OnClickCard?.Invoke(this);
    }
}
