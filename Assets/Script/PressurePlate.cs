using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Pressure plate triggers");
        }
    }
}
