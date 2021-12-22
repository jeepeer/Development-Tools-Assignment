using UnityEngine;
using UnityEngine.Events;

namespace Assignment.Scripts
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] private ScriptableEventBase scriptableEvent;
        [SerializeField] private UnityEvent response;
        
        private void OnEnable()
        {
            scriptableEvent.Subscribe(OnEventRaised);
        }

        private void OnDisable()
        {
            scriptableEvent.UnSubscribe(OnEventRaised);
        }

        private void OnEventRaised()
        {
            if(response != null)
            {
                response.Invoke();
            }
        }
    }
}
