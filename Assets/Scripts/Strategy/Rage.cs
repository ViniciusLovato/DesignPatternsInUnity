using UnityEngine;

public class Rage : IAbility
{
    public void Use(GameObject gameObject)
    {
        Debug.Log("I'm always angry");
    }
}
