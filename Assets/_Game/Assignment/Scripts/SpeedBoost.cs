using System.Collections;
using UnityEngine;

namespace Assignment.Scripts
{
    public class SpeedBoost : MonoBehaviour
    {
        [SerializeField] private FloatVariable throttleSpeed;
        [SerializeField] private FloatVariable boostedSpeed;
        [SerializeField] private float boostedTimeLeft;
        private float originalSpeed;
        private float BoostedSpeedValue
        {
            get => boostedSpeed.Value;
        }
        private bool isBoosted = false;
        
        public void MyMethod()
        {
            StartCoroutine(BoostedTimeLeft(boostedTimeLeft));
        }

        private IEnumerator BoostedTimeLeft(float timeLeft)
        {
            originalSpeed = throttleSpeed.Value;
            
            isBoosted = true;
            while (isBoosted)
            {
                throttleSpeed.Value = BoostedSpeedValue;
                yield return new WaitForSeconds(timeLeft);
                isBoosted = false;
            }
            throttleSpeed.Value = originalSpeed;
        }
    }
}
