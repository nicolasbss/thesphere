using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{

    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void Play1v1 ()
    {
        SceneManager.LoadScene(4);
    }
}
