using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    int currentHp = 100;
    int maxHp = 100;
    float weight = 2.5f;
    bool isAlive = true;
    EnemyHead head = new EnemyHead();
    EnemyHeart heart = new EnemyHeart();

    float Getweight()
    {
        return this.weight;
    }
    protected abstract string GetName();

    public void Moving()
    {
        string logMessage = this.GetName() + " Moving";
        Debug.Log(logMessage);
    }


}
