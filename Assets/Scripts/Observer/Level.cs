using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] private int experiencePerLevel = 200;
    private int currentExperience = 0;
    private int points = 8;

    // We can use UnityEvents 
    [SerializeField] private UnityEvent events;
    
    // Or we can use C# Actions
    public Action onLevelUp;
    
    // onLevelUp can be a delegate that takes level as parameter
    // Define the type of method we can have as a listener to an event
    // public delegate void CallbackType(float level);
    // public CallbackType onLevelUp1;
    
    // Actions can also require parameters
    // public Action<float> onLevelUp2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateExp());
    }

    IEnumerator UpdateExp()
    {
        while (true)
        {
            var currentLevel = GetLevel();
            currentExperience += points;
            if (GetLevel() > currentLevel)
            {
                // events.Invoke();
                onLevelUp?.Invoke();
            }
            
            yield return new WaitForSeconds(.2f);    
        }
    }

    public int GetExperience()
    {
        return currentExperience;
    }

    public int GetLevel()
    {
        return currentExperience / experiencePerLevel;
    }
}

