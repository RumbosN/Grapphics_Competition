using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject _portal;
    public int _cuantosCheck = 1;
    
    private int _llevoCheck = 0;
    public void deadPlayer()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void AddCheck()
    {
        _llevoCheck++;
        if(_llevoCheck == _cuantosCheck)
        {
            _portal.SetActive(true);
        }
    }
    public void NextLVL(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
}
