using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//buttons are allowed with UnityEngine.UI

public class Difficulty : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager is linked and different buttons are made unique to the computer
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    //difficulty is enabled and linked to GameManager script
    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
        Debug.Log(gameObject.name + " was clicked");
    }
}
