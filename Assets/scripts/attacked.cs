using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "attack")
        {
            Debug.Log("attacked");
            Destroy(this.gameObject);
        }
    }

}
