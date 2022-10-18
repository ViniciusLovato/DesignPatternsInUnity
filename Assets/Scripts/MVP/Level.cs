using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVP
{
   public class Level : MonoBehaviour
   {
       [SerializeField] int experiencePerLevel = 200;
       [SerializeField] UnityEvent onLevelUp;
       [SerializeField] private TextMeshProUGUI displayText;
       [SerializeField] private TextMeshProUGUI experienceText;
       [SerializeField] private Button increaseXPButton;
       private int experiencePoints = 0;

       public event Action onLevelUpAction;
 
       void Start()
       {
           UpdateUI();
           increaseXPButton.onClick.AddListener(() => GainExperience(10));
       }

       private void UpdateUI()
       {
           displayText.text = $"Level: {GetLevel()}";
           experienceText.text = $"Experience: {GetExperience()}";
       }

       private void GainExperience(int exp)
       {
           var level = GetLevel();
           experiencePoints += exp;
           UpdateUI();
           if (GetLevel() > level)
           {
               onLevelUp.Invoke();
               onLevelUpAction?.Invoke();
           }
       }
       
       public int GetExperience()
       {
           return experiencePoints;
       }
   
       public int GetLevel()
       {
           return experiencePoints / experiencePerLevel;
       }
   }
}
