using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDamage : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet") && gameObject != null)
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
