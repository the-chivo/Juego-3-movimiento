using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class endGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] playerHealth dead;
    [SerializeField] TMP_Text cronoTxt;
    float time;
    float crono;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        time += Time.deltaTime;
        CronoFunction();   
    }
    public void CronoFunction()
    {
        if(time >= 1 && dead.deadBool == false)
        {
            crono += 1;
            cronoTxt.text = crono.ToString();
            time = 0;
        }
        else cronoTxt.text = crono.ToString();
    }
    
}