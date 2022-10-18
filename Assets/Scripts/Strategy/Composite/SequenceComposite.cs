using System.Collections.Generic;
using UnityEngine;

public class SequenceComposite : IAbility
{
    private readonly List<IAbility> children;

    public SequenceComposite(List<IAbility> children)
    {
        this.children = children;
    }

    public void Use(GameObject gameObject)
    {
        children.ForEach(ability => ability.Use(gameObject));
    }
}
