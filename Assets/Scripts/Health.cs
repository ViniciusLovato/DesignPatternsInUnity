using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int damagePerHit = 1;

    private int currentHealh;
    // Start is called before the first frame update

    private void Awake()
    {
        currentHealh = maxHealth;
    }

    void Start()
    {
        StartCoroutine(TakeHit());
    }

    // Update is called once per frame
    IEnumerator TakeHit()
    {
        while (true)
        {
            currentHealh -= damagePerHit;
            yield return new WaitForSeconds(.2f);    
        }
    }

    public void ResetHealth()
    {
        currentHealh = maxHealth;
    }

    public int GetHealth()
    {
        return currentHealh;
    }
}
