using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Moves all transform children 10 units upwards!
    void Start()
    {
        foreach (Transform child in transform)
        {
            child.position += Vector3.up * 10.0f;
        }
    }
}
