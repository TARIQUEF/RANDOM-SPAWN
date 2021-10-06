using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public GameObject coin;
    public GameObject[] coins = new GameObject[5];
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i <5; i++)
        {
            int x = Random.Range(100, 900);
            var position = new Vector3(Random.Range(100, 900), 100, Random.Range(100, 900));
            Instantiate(coin, position, Quaternion.identity);
            coins[i] = coin;

        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
