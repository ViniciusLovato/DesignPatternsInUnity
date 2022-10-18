using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float fullHealh = 100f;
        [SerializeField] private float drainPerSecond = 2f;
        [SerializeField] private GameObject healthBar;
        private float currentHealth;
        
        // Start is called before the first frame update

        private void Awake()
        {
            ResetHealth();
            StartCoroutine(HealthDrain());
        }
        
        private void OnEnable()
        {
            GetComponent<Level>().onLevelUpAction += ResetHealth;
        }

        private void OnDisable()
        {
            GetComponent<Level>().onLevelUpAction -= ResetHealth;
        }

        private IEnumerator HealthDrain()
        {
            while (currentHealth > 0)
            {
                currentHealth -= drainPerSecond;
                UpdateUI();
                yield return new WaitForSeconds(1);
            }
        }
        
        void ResetHealth()
        {
            currentHealth = fullHealh;
        }

        public float GetHealth()
        {
            return currentHealth;
        }

        private void UpdateUI()
        {
            // This is just for demonstration purposes
            healthBar.GetComponent<Slider>().value = currentHealth / fullHealh;
        }
    }
}
