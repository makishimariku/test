using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float bottomY = Camera.main.transform.position.y
                         - Camera.main.orthographicSize * 2;

        // 忍者のY座標がbottomYより低い
        if (gameObject.transform.position.y < bottomY)
        {
            // 現在のシーンを再読み込み
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
