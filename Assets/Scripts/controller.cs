using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{   

    [SerializeField]
    string strTag;

    [SerializeField]
    string strTag2;

    [SerializeField]
    string strTag3;

    public Text tryText;
    public int tries;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -45)
        {   
            //SoundManager.PlaySound("gameOver");

            tries = tries + 1;

            transform.position = new Vector3(0,10,0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            SoundManager.PlaySound("gameOver");
        }
        tryText.text = "Tries: " + Mathf.Round(tries).ToString();
    }

   

    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.collider.tag == strTag){
            transform.position = new Vector3(0,10,0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            SoundManager.PlaySound("gameOver");
            tries = tries + 1;
        }

        if (collision.collider.tag == strTag2){
            
            SoundManager.PlaySound("trampolim");
            tries = tries + 1;
        }
        
        if (collision.collider.tag == strTag3){
            
             SceneManager.LoadScene(3);
        }
    }
}
