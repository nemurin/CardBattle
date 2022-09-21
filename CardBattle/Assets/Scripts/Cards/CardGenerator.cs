using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] GameObject canvas;
    [SerializeField] CardBase[] cardBases;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //cardの生成
    public Card Spawn(int number,int y){
        GameObject prefab = (GameObject)Instantiate(cardPrefab);
        prefab.transform.SetParent(canvas.transform, false);
        prefab.transform.localPosition = new Vector3(number*30,y);
        Card card = prefab.GetComponent(typeof(Card)) as Card;
        card.Set(cardBases[number]);
        return card;     
    }
}
