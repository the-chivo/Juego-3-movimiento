using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 10;
    [SerializeField] TMP_Text endGameText;
    
    
    void Start()
    {
        endGameText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.D))
        {
            vector += Vector3.right;
        }
         if(Input.GetKey(KeyCode.A))
        {
            vector += Vector3.left;
        }
         if(Input.GetKey(KeyCode.W))
        {
            vector += Vector3.up;
        }
         if(Input.GetKey(KeyCode.S))
        {
            vector += Vector3.down;
        }
        Vector3 vNormalized = vector/vector.magnitude;
        gameObject.transform.position += vector * speed * Time.deltaTime;
        
        
    }
    public void dead()
    {
        speed = 0;
        endGameText.enabled = true;
        if (Input.GetKeyDown(KeyCode.R))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
