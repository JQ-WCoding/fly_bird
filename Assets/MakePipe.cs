using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;

    private float timer = 0;

    public float timeDiff;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (!(timer > timeDiff)) return;

        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = new Vector3(0, Random.Range(-1.7f, 10.0f), 0);
        timer = 0;
    }
}