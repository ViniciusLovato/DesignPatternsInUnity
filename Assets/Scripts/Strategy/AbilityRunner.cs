using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    private readonly IAbility currentAbility = new Fireball();
    private readonly SequenceComposite sequenceComposite = 
        new SequenceComposite(
            new List<IAbility>()
            {
                new Fireball(), 
                new Rage(), 
                new Heal(),
                new DelayDecorator(new Fireball())
            }
        );
    
    public void UseAbility()
    {
        currentAbility.Use(gameObject);
    }

    public void UseDelayed()
    {
        var delayedAbility = new DelayDecorator(currentAbility);
        delayedAbility.Use(gameObject);
    }

    public void UseSequence()
    {
        sequenceComposite.Use(gameObject);
    }
}
