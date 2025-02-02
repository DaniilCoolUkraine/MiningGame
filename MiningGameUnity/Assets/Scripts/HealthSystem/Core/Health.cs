using System;
using UnityEngine;

namespace MiningGame.HealthSystem.Core
{
    public class Health
    {
        public event Action<int> OnHealthAdded;
        public event Action<int> OnHealthRemoved;

        public event Action OnDeath;

        public virtual int MaxHealth { get; protected set; }
        public virtual int CurrentHealth { get; protected set; }

        public Health()
        {
            MaxHealth = 1;
            CurrentHealth = 1;
        }
        
        public Health(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void AddHealth(int amount)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth += amount, 0, MaxHealth);
            OnHealthAdded?.Invoke(CurrentHealth);
        }

        public void RemoveHealth(int amount)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth -= amount, 0, MaxHealth);

            if (CurrentHealth <= 0)
                OnDeath?.Invoke();
            else
                OnHealthRemoved?.Invoke(CurrentHealth);
        }
    }
}