using UnityEngine;

public class Fireball : IAbility
{
    public void Use(GameObject gameObject)
    {
        Debug.Log("Fire!");
    }
}
