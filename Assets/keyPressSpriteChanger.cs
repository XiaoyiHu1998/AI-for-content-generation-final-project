using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class keyPressSpriteChanger : MonoBehaviour
{
    private bool keyDown = false;

    public KeyCode keyCode;
    public Texture keyUnpressedTexture;
    public Texture keyPressedTexture;
    public RawImage rawImage;

    public AudioClip keyPressSound;
    public AudioSource audioSource;

    private void Start()
    {
        rawImage.texture = keyUnpressedTexture;
    }

    void Update()
    {
        if (keyDown != Input.GetKey(keyCode))
        {
            keyDown = !keyDown;

            rawImage.texture = keyDown ? keyPressedTexture : keyUnpressedTexture;
            audioSource.clip = keyPressSound;
            audioSource.Play();
        }
    }
}
