using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleBook : MonoBehaviour
{
    public Result GetResult(Battler player,Battler enemy){
        if(player.SubmitCard.Base.power > enemy.SubmitCard.Base.power){
            return Result.TurnWin;
        }
        else if(player.SubmitCard.Base.power > enemy.SubmitCard.Base.power){
            return Result.TurnLose;
        }
        return Result.TurnDraw;
    }
}
public enum Result{
    TurnWin,
    TurnLose,
    TurnDraw,
    GameWin,
    GameLose,
    GameDraw,
}
