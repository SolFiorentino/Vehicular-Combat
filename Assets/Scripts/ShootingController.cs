using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletForce = 1000f;
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private float bulletLifetime = 3f; // Tiempo de vida de la bala

    private float nextFireTime = 0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        // Capturar la dirección actual del spawn point
        Vector3 shootDirection = bulletSpawnPoint.forward;

        // Crear la bala y alinear su rotación inicial con la del spawn point
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.LookRotation(shootDirection));
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Aplicar la fuerza en la dirección capturada
        rb.AddForce(shootDirection * bulletForce, ForceMode.Impulse);

        // Desactivar la rotación de la bala para que no gire
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        // Destruir la bala después de un tiempo
        Destroy(bullet, bulletLifetime);
    }
}





