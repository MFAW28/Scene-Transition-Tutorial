using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator animSlideScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(changeScene("Scene1"));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(changeScene("Scene2"));
        }
    }

    IEnumerator changeScene(string nameScene)
    {
        animSlideScene.SetTrigger("SlideScene");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nameScene);
    }
}
