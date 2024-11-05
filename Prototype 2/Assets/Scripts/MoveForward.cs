using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Start()
    {
        
    }
    [SerializeField] private float speed = 40f;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward); 
    }
}
