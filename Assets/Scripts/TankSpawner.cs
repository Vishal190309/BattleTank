using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tankPrefab;
    void Start()
    {
        Instantiate(tankPrefab,transform.position,Quaternion.identity);
    }
}
