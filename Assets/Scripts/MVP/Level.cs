using System;
using UnityEngine;

namespace MVP
{
   public class Level : MonoBehaviour
   {
       [SerializeField] int experiencePerLevel = 200;
       private int experiencePoints = 0;

       public event Action OnLevelUpAction;
       public event Action OnExperienceChange;
 
       public void GainExperience(int exp)
       {
           var level = GetLevel();
           experiencePoints += exp;

           OnExperienceChange?.Invoke();
           
           if (GetLevel() > level)
           {
               OnLevelUpAction?.Invoke();
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
