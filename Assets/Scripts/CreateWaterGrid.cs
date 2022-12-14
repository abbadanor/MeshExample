using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWaterGrid : MonoBehaviour
{
    public int size;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // temporary fix to lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        int offset = (size * 10) / 2 - 5;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Instantiate(prefab, new Vector3(10*i - offset, 0, 10*j - offset), Quaternion.identity);
            //Instantiate(prefab, new Vector3(x_Space+ (x_Space*(i % columnLength)), 0, z_Space + (z_Space * (i % columnLength))), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
