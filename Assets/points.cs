using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class points : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text scoreTxt;
    int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            score += 1;
            scoreTxt.text = score.ToSafeString();
            gameObject.transform.position = new Vector3 (Random.Range(-8,8), Random.Range(4.40f, -4.40f),0);
        }
    }
}
