using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Rikishi : MonoBehaviour
{
    private float _weight;
    private string _category;
  
    public string Name { get; set; }
    public float Weight
    {
        get { return _weight;  }
        set 
        { if (value > 0)  // ENCAPSULATION
            {
                _weight = value;
            }
            else 
            {
                Debug.Log("You can't set a negative weight!"); 
            }
        }
    }

    public string Category
    {
        get { return _category; }
        set 
        {
            switch(value)  // ENCAPSULATION
            {
                case "Yokozuna":
                    _category = value;
                    break;
                case "Ozeki":
                    _category = value;
                    break;
                case "Sekiwake":
                    _category = value;
                    break;
                case "Komusubi":
                    _category = value;
                    break;
                default:
                    _category = "";
                    Debug.Log("Valid categories are: Yokozuna, Ozeki, Sekiwake and Koumusubi."); 
                    break; 
            }
        }
    }

    public abstract void Attack(); 

    public abstract void Jump(); 
 
    public virtual void PullBack()
    {

    }

    public virtual void OpponentMove()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Floor"))
        {
            Debug.Log("Game over!"); 
        }
    }

}
