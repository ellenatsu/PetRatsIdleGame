using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mao : MonoBehaviour
{
    public int curFull;
    public int maxFull;

    public int hungerToFeed;

    public Image hunerBarFill;

    public void Feed(){
        curFull++;
        hunerBarFill.fillAmount = (float)curFull / (float) maxFull;

        if(curFull >= maxFull){
            FinishMeal();
        }
    }

    public void FinishMeal(){
        //
    }
}
