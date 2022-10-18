using System;
using System.Collections;
using UnityEngine;

namespace MVP
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float fullHealth = 100f;
        [SerializeField] private float drainPerSecond = 2f;
        private float currentHealth;

        public event Action OnHealthChange;
        
        // Start is called before the first frame update

        private void Awake()
        {
            ResetHealth();
            StartCoroutine(HealthDrain());
        }
        
        private void OnEnable()
        {
            GetComponent<Level>().OnLevelUpAction += ResetHealth;
        }

        private void OnDisable()
        {
            GetComponent<Level>().OnLevelUpAction -= ResetHealth;
        }

        private IEnumerator HealthDrain()
        {
            while (currentHealth > 0)
            {
                currentHealth -= drainPerSecond;
                OnHealthChange?.Invoke();
                
                yield return new WaitForSeconds(1);
            }
        }
        
        void ResetHealth()
        {
            currentHealth = fullHealth;
            OnHealthChange?.Invoke();
        }

        public float GetHealth()
        {
            return currentHealth;
        }

        public float GetFullHealth()
        {
            return fullHealth;
        }
    }
}
