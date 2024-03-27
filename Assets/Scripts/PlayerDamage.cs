using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage = 10.0f;
    public float attackRange = 2.0f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            // Cast a ray from the camera's position in the camera's forward direction
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, attackRange, enemyLayer))
            {
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damage);
                }
            }
        }
    }
}
