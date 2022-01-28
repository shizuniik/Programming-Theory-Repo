using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool onFloor;
    // Start is called before the first frame update
    void Start()
    {
        onFloor = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime);
        gameObject.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime); 

        if(Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            gameObject.GetComponent<Rikishi>().Jump(); 
            onFloor = false; 
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<Rikishi>().Attack(); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Dohyo"))
        {
            onFloor = true; 
        }

    }



}
