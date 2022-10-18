using System;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private GameObject healthBar;

        private void Start()
        {
            health.OnHealthChange += UpdateUI;
        }

        private void UpdateUI()
        {
            // This is just for demonstration purposes
            healthBar.GetComponent<Slider>().value = health.GetHealth() / health.GetFullHealth();
        }
    }
}