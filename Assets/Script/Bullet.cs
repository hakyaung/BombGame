using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 100f;
    private float enableTime = 0f;
    private float lifeTime = 10f;
    private Vector3 poolPosition = new Vector3(50, -50, 50);
    private Transform playerTrans;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        playerTrans = GameObject.FindWithTag("Player").transform;
    }
    void OnEnable() { 
        enableTime = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > enableTime + lifeTime)
        {
            transform.position = poolPosition;
            gameObject.SetActive(false);
        }
        else
        {
            transform.Translate(playerTrans.forward * speed * Time.deltaTime);
        }
    }
}
