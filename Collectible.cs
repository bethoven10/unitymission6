using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    // Trigger detection
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
