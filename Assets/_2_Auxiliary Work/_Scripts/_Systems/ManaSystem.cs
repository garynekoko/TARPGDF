using System;
using UnityEngine;

namespace iii_UMVR06_TPSDefenseGame_Subroutines_2 {

    public class ManaSystem {

        public event EventHandler OnManaChanged;

        private int maxManaPoint;
        private int currentManaPoint;

        public ManaSystem(float maxManaPoint) {
            this.maxManaPoint = (int)maxManaPoint;
            currentManaPoint = this.maxManaPoint;
        }

        public float GetManaPercent() {
            float currentManaPercent = currentManaPoint / (float)maxManaPoint;
            return currentManaPercent;
        }

        public void CalculateManaPoint(float manaConsumedPoint) {
            currentManaPoint -= (int)manaConsumedPoint;
            if(currentManaPoint <= 0) { currentManaPoint = 0; }
            OnManaChanged?.Invoke(this, EventArgs.Empty);
        }

    }

}