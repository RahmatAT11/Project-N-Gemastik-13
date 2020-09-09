using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneNameNext;
    public string sceneNamePrevious;

    public void PlayGameButton()
    {
        StartCoroutine(SceneLoadNext());
    }

    public void BackSceneButton()
    {
        StartCoroutine(SceneLoadPrevious());
    }

    IEnumerator SceneLoadNext()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneNameNext);
    }

    IEnumerator SceneLoadPrevious()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneNamePrevious);
    }
}
