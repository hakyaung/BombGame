using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermySpawner : MonoBehaviour
{
    public GameObject enermyPrefab; 
    private int count = 30; 
    private GameObject[] enermys;
    // Start is called before the first frame update
    void Start()
    {
        enermys = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-30, 30), 0.5f, Random.Range(-30, 30));
            enermys[i] = Instantiate(enermyPrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
