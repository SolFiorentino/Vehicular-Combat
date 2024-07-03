using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Desactivar la gravedad para la bala
    }
}

