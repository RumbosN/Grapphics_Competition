using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Start : MonoBehaviour
{
    public GameObject _InfoContainer;
    private bool _snactivo;

    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartButtton()
    {
        SceneManager.LoadScene("IntroductionVR");
    }

    public void InfoButton()
    {
        if(_snactivo)
        {
            _snactivo = false;
        }
        else
        {
            _snactivo = true;
        }
        _InfoContainer.SetActive(_snactivo);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("StartGame");
    }
}