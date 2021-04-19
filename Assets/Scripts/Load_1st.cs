using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load_1st : MonoBehaviour
{
    // 非同期動作で使用するAsyncOperation
    // private AsyncOperation async;
    // fadeOutのfade_out()のためのGameObject
    public GameObject fade_out;

    public void nextScene()
    {
        StartCoroutine("SceneCoroutine");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SceneCoroutine()
    {
        // シーンの読み込みをする
        AsyncOperation async = SceneManager.LoadSceneAsync("1stScene");
        Debug.Log("シーン読み込み開始");

        // ロードが完了していても、シーンのアクティブ化は許可しない
        async.allowSceneActivation = false;

        // フェードアウトを行う
        fade_out.GetComponent<fadeOut>().fade_out();

        // フェードアウト完了まで待つ
        yield return new WaitForSeconds(3.5f);

        // ロードが完了したときにシーンのアクティブ化を許可する
        async.allowSceneActivation = true;

        yield return null;
    }
}