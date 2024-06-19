using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public ParticleSystem popParticle;
    public GameObject range;
    private bool onCollision;

    // Start is called before the first frame update
    void Start()
    {
        onCollision = false;
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (onCollision == true) return;
        if (collision.gameObject.tag == "attack")
        {
            Instantiate(popParticle, transform.position, Quaternion.identity);
            Instantiate(range, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            onCollision = true;
        }
    }
}
