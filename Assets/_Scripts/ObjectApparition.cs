using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectApparition : MonoBehaviour
{
    public float smoothFactor = 2;
    public GameObject myPrefab;
    private bool isInstantiated = false;
    private GameObject player;

    private Vector3 basePos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        basePos = new Vector3(0, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 2, transform.position.z), Time.deltaTime * smoothFactor);
        if (transform.position.y >= -1 && gameObject.CompareTag("Photo") && isInstantiated == false)
        {
            Instantiate(myPrefab, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.Euler(-90, 0, 0));
            isInstantiated = true;
        }
        Vector3 playerPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        transform.LookAt(playerPosition);

    }


}
