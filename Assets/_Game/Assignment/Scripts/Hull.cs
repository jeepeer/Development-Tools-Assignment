using UnityEngine;

namespace Assignment.Scripts
{
    public class Hull : MonoBehaviour
    {
        [SerializeField] private ScriptableEventBase scriptableEvent;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                return;
            }
            
            scriptableEvent.Raise();
        }
    }
}
