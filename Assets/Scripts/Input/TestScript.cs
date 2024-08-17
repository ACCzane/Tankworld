using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField]private InputReader inputReader;
    // Start is called before the first frame update
    void Start()
    {
        inputReader.MoveEvent += HandleMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy() {
        inputReader.MoveEvent -= HandleMove;   
    }

    private void HandleMove(Vector2 vector)
    {
        Debug.Log(vector);
    }
}
