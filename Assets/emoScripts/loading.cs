using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    // 非同期動作で使用するAsyncOperation
    private AsyncOperation async;
    // シーンロード中に表示するUI画面
    [SerializeField]
    private GameObject loadUI;
    // 読み込み率を表示するスライダー
    [SerializeField]
    private Slider slider;

    public void nextScene()
    {
        // ロード画面UIをアクティブにする
        loadUI.SetActive(true);

        // コルーチンを開始
        StartCoroutine("loadData");
    }

    IEnumerator loadData()
    {
        // シーンの読み込みをする
        async = SceneManager.LoadSceneAsync("emo_testScene");

        // 読み込みが終わるまで進捗状況をスライダーの値に反映させる
        while(!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
