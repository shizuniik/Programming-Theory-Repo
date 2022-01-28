using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sekiwake : Rikishi
{
    [SerializeField] float force;
    [SerializeField] float speed;
    [SerializeField] Vector3 startForce; 
    private GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        this.Category = "Sekiwake";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack() 
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force , ForceMode.Impulse);
    }

    public override void Jump()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    public override void EnemyMove()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(startForce, ForceMode.Impulse); 
    }

}
