using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchWindow : MonoBehaviour
{
    public Button doneButton;
    // Start is called before the first frame update
    public void Start()
    {
        playButton.onClick.AddListener(MoveWindow);
        
    }

    // Update is called once per frame
    void MoveWindow()
    {
        SceneManager.LoadScene("GameScene");
        
        
    }
}
