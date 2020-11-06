using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour

{

    public static AudioClip  trampolimSound, rollSound, gameOverSound, explosionSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
       
        gameOverSound = Resources.Load<AudioClip> ("game_over_17");
        rollSound = Resources.Load<AudioClip> ("jump_05");
        trampolimSound = Resources.Load<AudioClip> ("jump_19");
        explosionSound = Resources.Load<AudioClip> ("explosion_20");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "move":
                audioSrc.PlayOneShot(rollSound);
                break;
            case "trampolim":
                audioSrc.PlayOneShot(trampolimSound);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound);
                break;
            case "explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;
        }
    }
}
