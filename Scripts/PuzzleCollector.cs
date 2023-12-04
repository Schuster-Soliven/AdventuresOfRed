using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PuzzleCollector : MonoBehaviour
{
    public static PuzzleCollector instance;

    public TMP_Text pieceText;
    public int currentPieces = 0;
    public int TotalPieces = 1;
    AudioSource collect;

    void Awake() {
        instance = this;
    }
    void Start() {
        pieceText.text = "Pieces Collected: " + currentPieces.ToString();
        collect = GetComponent<AudioSource>();
    } 

    public void IncreasePiece (int v) 
    {
        currentPieces += v;
        collect.Play();
        pieceText.text = "Pieces Collected: " + currentPieces.ToString();
        if (currentPieces >= TotalPieces ) {
            if (SceneManager.GetActiveScene().buildIndex == 3) {
                SceneManager.LoadScene("VictoryScreen");
            } else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
        }
    } 
}
