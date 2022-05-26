using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 currentPosition;
    private Vector3 initialRot;

    void Start()
    {
        // 初期位置（ゲームスタート時点の位置）
        initialPosition = transform.position;

        // 初期角度（ゲームスタート時点の角度）
        initialRot = transform.eulerAngles;
    }

    void Update()
    {
        // 現在の位置
        currentPosition = transform.position;

        if (currentPosition.y < -10f)
        {
            // 初期位置に戻す。
            transform.position = initialPosition;

            // 初期角度に戻す。
            transform.eulerAngles = initialRot;
        }
    }
}