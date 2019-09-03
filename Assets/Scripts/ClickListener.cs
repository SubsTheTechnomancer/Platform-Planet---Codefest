using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickListener : MonoBehaviour {

    public Button play, exit;
    public string NextScene;

    private void Start()
    {
        Button b1 = play.GetComponent<Button>();
        Button b2 = exit.GetComponent<Button>();
        b1.onClick.AddListener(() => OnPlay());
        b2.onClick.AddListener(() => OnExit());
    }

    void OnPlay()
    {
        SceneManager.LoadScene(NextScene);
    }

    void OnExit()
    {
        Application.Quit();
    }
}
