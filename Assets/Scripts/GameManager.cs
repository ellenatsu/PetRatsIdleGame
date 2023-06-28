using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int hunger;
    

    public static GameManager instance;

    void Awake(){
        instance = this;
    }

    public void feedHunger(int amount){
        hunger -= amount;
    }

    public void addHunger(int amount){
        hunger += amount;
    }
}
