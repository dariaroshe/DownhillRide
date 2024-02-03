using UnityEngine;

namespace Game
{
    public class TriggerDestroyComponent : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}