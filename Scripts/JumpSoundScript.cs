using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSoundScript : MonoBehaviour
{
    public AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame


    // On an Animation Event play sound
    private void PlayerJumpSound()
    {
        jumpSound.Play();
    }
}
