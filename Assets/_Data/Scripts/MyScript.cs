using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.TestOperator();
        this.TestClass();
    }

    void TestOperator()
    {
        int variable = 100;
        Debug.Log("Variable: " + variable);
    }
    void TestClass()
    {
        Zombie zombie = new Zombie();
        Wolf wolf = new Wolf();
        Eagle eagle = new Eagle();
        Ghost ghost = new Ghost();

        zombie.Moving();
        wolf.Moving();
        eagle.Moving();
        ghost.Moving();
    }
}
