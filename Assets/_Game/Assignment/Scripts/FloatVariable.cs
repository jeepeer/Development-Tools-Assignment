using UnityEngine;

namespace Assignment.Scripts
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObject/Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private float value;
        private float _currentValue;

        public float Value
        {
            get => _currentValue;
            set => _currentValue = value;
        }
        
        private void OnEnable()
        {
            _currentValue = value;
        }
    }
}
