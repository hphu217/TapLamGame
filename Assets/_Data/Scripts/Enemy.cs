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


    public virtual bool  IsDead()
    {
        if (this.currentHp <= 0)
        {
            this.isAlive = false;
            return true;
        }
        else
        {
            return false;
        }
    }
    float Getweight()
    {
        return this.weight;
    }
    public abstract string GetName();

    public virtual float GetCurrentHP()
    {
        return this.currentHp;
    }

    public virtual void SetHP(int hp)
    {
        this.currentHp = hp;
    }
    public void Moving()
    {
        string logMessage = this.GetName() + " Moving";
        Debug.Log(logMessage);
    }



}
