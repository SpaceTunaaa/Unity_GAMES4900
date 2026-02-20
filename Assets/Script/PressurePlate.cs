using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other is player)
        {
            Debug.Log("Player Entered");
        }
    }
}
