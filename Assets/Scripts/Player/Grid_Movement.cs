using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Movement : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.up));

        if (Input.GetKey(KeyCode.A) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.left));

        if (Input.GetKey(KeyCode.S) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.down));

        if (Input.GetKey(KeyCode.D) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.right));

    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedtime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;
        while (elapsedtime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedtime / timeToMove));
            elapsedtime += Time.deltaTime;
            yield return null;
        }
    
    transform.position = targetPos;

        isMoving=false;
    }
}

