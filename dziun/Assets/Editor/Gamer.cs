using System;
using UnityEngine;
 public class Hero
{
        public int CurrentHealth { get; private set; }

        public Hero(int currentHealth, int maximumHealth = 100)
        {
            if (currentHealth < 0) throw new System.ArgumentOutOfRangeException("currentHealth");
            if (currentHealth > maximumHealth) throw new System.ArgumentOutOfRangeException("currentHealth");
            CurrentHealth = currentHealth;
            maximumHealth = maximumHealth;
        }

    public void Damage(int amount)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - amount, 0);
    }
}