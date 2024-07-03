using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    [SerializeField] private Transform player; // Referencia al jugador
    [SerializeField] private float speed = 10f; // Velocidad del coche enemigo
    [SerializeField] private float turnSpeed = 5f; // Velocidad de giro del coche enemigo

    private void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        // Calcular la dirección hacia el jugador
        Vector3 direction = (player.position - transform.position).normalized;

        // Rotar el coche enemigo hacia la dirección del jugador
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);

        // Mover el coche enemigo hacia el jugador
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}

