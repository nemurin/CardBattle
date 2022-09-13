using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] int playerHp;
    [SerializeField] TextMeshProUGUI playerTextObject;
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
}
