using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    private readonly IAbility currentAbility = new Fireball();

    public void UseAbility()
    {
        currentAbility.Use(gameObject);
    }
}
