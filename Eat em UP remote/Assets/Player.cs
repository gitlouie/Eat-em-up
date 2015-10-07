using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private float health;
    private string name;

    //initalize the player based on the inputs
    public Player(int health, string name)
    {
        this.health = health;
        this.name = name;

    }

    public float getHealth()
    {
        return health;
    }

    public string getName()
    {
        return name;
    }

}
