using System;
using UnityEngine;

namespace Assignment.Scripts
{    
    [CreateAssetMenu(fileName = "new ScriptableEvent", menuName = "ScriptableObject/ScriptableEvent")]
    public class ScriptableEventBase : ScriptableObject
    {
        private event Action eventNoPayload;

        public void Subscribe(Action onEventNoPayload)
        {
            eventNoPayload += onEventNoPayload;
        }
        
        public void UnSubscribe(Action onEventNoPayload)
        {
            eventNoPayload -= onEventNoPayload;
        }
        
        public void Raise()
        {
            eventNoPayload?.Invoke();
        }
    }
}
