using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] private int experiencePerLevel = 200;
    private int currentExperience = 0;
    private int points = 8;

    [SerializeField] private UnityEvent events;
    
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
                events.Invoke();
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
