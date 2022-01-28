using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> listRikishis;
    private int level;
    private GameObject opponent;
    public GameObject player;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        opponent = SpawnRikishi(); // ABSTRACTION
        Instantiate(opponent);

        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        opponent.GetComponent<Rikishi>().EnemyMove(); 
    }
    private GameObject SpawnRikishi()
    {
        int index = level;
        return listRikishis[index];
    }


}
