using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int count = 100;
    public GameObject bulletPrefab;
    private GameObject[] bullets;
    private Vector3 poolPosition = new Vector3(50, -50, 50);
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        bullets = new GameObject[count];
        for(int i = 0; i < count; i++)
        {
            bullets[i] = Instantiate(bulletPrefab, poolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameover)
        {
            Destroy(gameObject);
        }
        if(Input.GetAxis("Fire1") > 0)
        {
            bullets[index].transform.position = transform.position + new Vector3(0, 0.3f, 0);
            bullets[index].SetActive(true);
            index++;
            index %= count;
        }
    }
}
