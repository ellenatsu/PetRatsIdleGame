using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int foodTotal = 100;
    
    public TextMeshProUGUI foodAmountText;

    public static GameManager instance;

    void Awake(){
        instance = this;
    }

    public void feedPets(int amount){
        foodTotal -= amount;
        foodAmountText.text = "Food Left: " + foodTotal.ToString();
    }

    public void addFood(int amount){
        foodTotal += amount;
        foodAmountText.text = "Food Left: " + foodTotal.ToString();
    }
}
