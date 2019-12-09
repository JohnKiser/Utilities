using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulCodeNotInScenes : MonoBehaviour {

    #region Destroy all objects with tag

    public void DestroyAll()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject obj in allObjects)
        {
            Destroy(obj);
        }
    }
    #endregion

    #region Creating a raycast

    public LineRenderer line;
    public float width = 0.01f;
    public float length = 5f;
    public RaycastHit raycastHit;

    private void Start()
    {
        Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        line.SetPositions(initLaserPositions);
        line.startWidth = width;
        line.endWidth = width;
    }

    // Update is called once per frame
    void Update()
    {
        MakeRaycast(this.transform.position);
    }

    public void MakeRaycast(Vector3 origin)
    {
        Ray ray = new Ray(origin, (this.transform.forward));

        Vector3 endPosition = origin + (length * this.transform.forward);

        if (Physics.Raycast(ray, out raycastHit, length))
        {
            endPosition = raycastHit.point;
        }
        line.SetPosition(0, origin);
        line.SetPosition(1, endPosition);
    }
    #endregion

    #region Follow player

    public GameObject Player;
    public float movementSpeed = 1;
    public float approachDistance = 2.0f;
    void Update()
    {
        Vector3 position = transform.position;
        float distanceToPlayer = Vector3.Distance(position, Player.transform.position);
        transform.LookAt(Player.transform);
        if (distanceToPlayer > approachDistance)
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
    }
    #endregion

    #region Move Object to a position over a set time

    private GameObject spawnPoint;
    private GameObject endPoint;

    public float BPS;

    private float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        BPS = 120;
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnNote");
        endPoint = GameObject.FindGameObjectWithTag("EndPoint");
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / (BPS * 4);
        transform.position = Vector3.Lerp(spawnPoint.transform.position, endPoint.transform.position, t);
    }
    #endregion

}
