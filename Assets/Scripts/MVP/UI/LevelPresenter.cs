using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class LevelPresenter : MonoBehaviour
    {
        [SerializeField] private Level level;
        [SerializeField] private TextMeshProUGUI displayText;
        [SerializeField] private TextMeshProUGUI experienceText;
        [SerializeField] private Button increaseXpButton;

        private void Start()
        {
            increaseXpButton.onClick.AddListener(() => level.GainExperience(10));
            level.OnExperienceChange += UpdateUI;
            UpdateUI();
        }

        private void UpdateUI()
        {
            displayText.text = $"Level: {level.GetLevel()}";
            experienceText.text = $"Experience: {level.GetExperience()}";
        }
        
    }
}