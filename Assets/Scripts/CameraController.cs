using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player; // 玉のオブジェクト

    private Vector3 offset; // 玉からカメラまでの距離

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}