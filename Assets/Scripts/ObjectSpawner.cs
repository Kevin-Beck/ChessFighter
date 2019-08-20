using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objects;
    public float force;
    public Vector3 Direction;
    public float TimerMin;
    public float TimerMax;
    private float CurTimer;
    public float InitialDelay;
    public bool spanX;
    public bool spanZ;
    public float spanSize;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", InitialDelay);
        CurTimer = TimerMax;
    }

    private void Spawn()
    {
        GameObject go = Instantiate(objects[Random.Range(0, objects.Count)]);
        go.transform.position = transform.position;
        if (spanX)
        {
            go.transform.position = new Vector3(Random.Range(0f, spanSize), go.transform.position.y, go.transform.position.z);
        }
        if (spanZ)
        {
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, Random.Range(0f, spanSize));
        }
        go.GetComponent<Rigidbody>().AddForce(Direction * force);

        if (CurTimer < TimerMin)
            Invoke("Spawn", TimerMin);
        else
        {
            CurTimer *= .9f;
            Invoke("Spawn", CurTimer);
        }
    }
}
