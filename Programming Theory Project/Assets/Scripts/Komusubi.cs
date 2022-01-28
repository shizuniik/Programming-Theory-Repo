using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Komusubi : Rikishi
{
    [SerializeField] float force;
    [SerializeField] float speed;

    public override void Attack()  
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.Category = "Komusubi";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Jump()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
