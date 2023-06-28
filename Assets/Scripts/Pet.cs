using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pet : MonoBehaviour
{
    public int curFull;
    public int maxFull;

    public int hungerToFeed;

    //this is like a factory class mode, how to specify the certain one animal?
    //public bool isFull;

    public Image hungerBarFill;

    public void Feed(){
        curFull+= 1;
        hungerBarFill.fillAmount = (float) curFull / (float) maxFull;

        if(curFull == maxFull){
            FinishMeal();
        }
    }

    public void FinishMeal(){
        //starting with curFull always = 0
        GameManager.instance.feedPets(hungerToFeed);
        PetsManager.instance.ReplacePet(gameObject);
    }
}
