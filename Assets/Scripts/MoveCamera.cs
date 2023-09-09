using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] float smoothing;

    Vector3 targetPos;
    [SerializeField] Vector2 maxPos;
    [SerializeField] Vector2 minPos;

    void FixedUpdate()
    {
        if(_player.position != transform.position)
        {
            targetPos = new Vector3(_player.position.x, _player.position.y, 0f);

            targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);
            transform.position = new Vector3(MoveCoordinates().x,MoveCoordinates().y, -10f);
        }
    }

    Vector2 MoveCoordinates()
    {
        

        return Vector2.Lerp(transform.position, targetPos, smoothing);
    }
}
