using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokozuna : Rikishi  // INHERITANCE
{
    [SerializeField] float force;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        this.Category = "Yokozuna";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Attack() // POLYMORPHISM 
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse); 
    }

    public override void Jump() // POLYMORPHISM 
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
    }

}
