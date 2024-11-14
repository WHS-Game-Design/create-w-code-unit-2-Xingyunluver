using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Start()
    {
        
    }
    [SerializeField] private float speed = 40f;

    private float limitZ = 30;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward); 
        if(Mathf.Abs(transform.position.z) > limitZ)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < -limitZ)
        {
            Debug.Log("Fail! Get Out!");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Dusk's rain it too shall fall");
        Destroy(collider.gameObject);
        Destroy(gameObject);
    }
}
