using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float speed = 8;
    [SerializeField] Transform player;
    [SerializeField] float damage = 10;
    [SerializeField] playerHealth end;
    [SerializeField] Gradient color;
    [SerializeField] float maxSpeed = 9;
    [SerializeField] float minSpeed = 4;
    float normalized;
    Color enemyColor;
    float velocityNumber;
    SpriteRenderer SpriteRenderer;

    
    void Start()
    {   
        SpriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        end = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();
        speed = Random.Range(minSpeed,maxSpeed);
        NormalizeNumber();
        enemyColor = color.Evaluate(normalized);
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.color = enemyColor;
    }
    public void NormalizeNumber()
    {
        velocityNumber = speed - minSpeed;
        normalized = maxSpeed - minSpeed;
        normalized = velocityNumber / normalized;
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
        
    }
    public void enemyMovement()
    {
        Vector3 direction = player.position - gameObject.transform.position;
        if(end.deadBool == true)
        {
            direction *= -1;
        }
        else direction *= 1;
        gameObject.transform.position += direction.normalized * Time.deltaTime * speed;
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerHealth>().takeDamage(damage);
        }
    }
}
