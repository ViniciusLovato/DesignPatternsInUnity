using UnityEngine;

public class DelayDecorator : IAbility
{
    private readonly IAbility ability;

    public DelayDecorator(IAbility ability)
    {
        this.ability = ability;
    }

    public void Use(GameObject gameObject)
    {
        Debug.Log("Delay!");
        ability.Use(gameObject);
    }
}
