using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller1 : MonoBehaviour
{   

    [SerializeField]
    string strTag;

    [SerializeField]
    string strTag2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10)
        {   

           SceneManager.LoadScene(6);
    
        }

    }

   

    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.collider.tag == strTag){    
            SoundManager.PlaySound("explosion");
        }

        
        if (collision.collider.tag == strTag2){
            
             SceneManager.LoadScene(6);
        }
    }
}
