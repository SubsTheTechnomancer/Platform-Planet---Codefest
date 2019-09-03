using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelClick : MonoBehaviour {

    public Button _1, _2, _3, _4, _5, _6, _7, _8;

	void Start () {
        _1.GetComponent<Button>().onClick.AddListener(() => one());
        _2.GetComponent<Button>().onClick.AddListener(() => two());
        _3.GetComponent<Button>().onClick.AddListener(() => three());
        _4.GetComponent<Button>().onClick.AddListener(() => four());
        _5.GetComponent<Button>().onClick.AddListener(() => five());
        _6.GetComponent<Button>().onClick.AddListener(() => six());
        _7.GetComponent<Button>().onClick.AddListener(() => seven());
        _8.GetComponent<Button>().onClick.AddListener(() => eight());

    }
	
	void one()
    {
        SceneManager.LoadSceneAsync("Level1");
    }

    void two()
    {
        SceneManager.LoadSceneAsync("Level2");
    }

    void three()
    {
        SceneManager.LoadSceneAsync("Level3");
    }

    void four()
    {
        SceneManager.LoadSceneAsync("Level4");
    }

    void five()
    {
        SceneManager.LoadSceneAsync("Level5");
    }

    void six()
    {
        SceneManager.LoadSceneAsync("Level6");
    }

    void seven()
    {
        SceneManager.LoadSceneAsync("Level7");
    }

    void eight()
    {
        SceneManager.LoadSceneAsync("Level8");
    }
}
