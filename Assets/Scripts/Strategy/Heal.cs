using UnityEngine;

public class Heal : IAbility
{
    public void Use(GameObject gameObject)
    {
        Debug.Log("Healing!");
    }
}
