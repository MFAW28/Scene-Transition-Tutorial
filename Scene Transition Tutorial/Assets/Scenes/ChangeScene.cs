using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator animationScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animationScene.SetTrigger("SceneOut");
            StartCoroutine(SceneTransition());
        }
    }

    IEnumerator SceneTransition()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene2");
    }
}
