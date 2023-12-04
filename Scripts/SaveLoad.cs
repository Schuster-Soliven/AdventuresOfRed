using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public float x, y, z;
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save() {
        x = transform.position.x;
        y = transform.position.y;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
    }

    public void Load() {
        x =  PlayerPrefs.GetFloat("x");
        y =  PlayerPrefs.GetFloat("y");
        Vector2 LoadPosition = new Vector2(x, y);
        transform.position = LoadPosition;
    }
}
