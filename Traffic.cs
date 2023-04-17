using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public float velocity = 10f;
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.GetComponent<BoxCollider>();
        col.enabled = false;
        Invoke("EnableCollider", 1f);
        Invoke("DestroyTraffic", 100f);
    }

    // Update is called once per frame
    void Update()
    {
        
        float displacement = velocity * Time.deltaTime;
        Vector3 disp = transform.forward * displacement;
        transform.position += disp;
        displacement = 0f;
    }

    void EnableCollider()
    {
        col.enabled = true;
    }

    void DestroyTraffic()
    {
        Destroy(this.gameObject);
    }
}
