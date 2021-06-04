using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public float timeUntilSceneChange = 0.0f;

    private void Start()
    {
        StartCoroutine(ChangeScene());
    }

    protected IEnumerator ChangeScene() 
    {
        yield return new WaitForSeconds(timeUntilSceneChange);

        SceneManager.LoadScene("Level1");

        yield return null;
    }
}
