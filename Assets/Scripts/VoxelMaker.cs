using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelMaker : MonoBehaviour
{
    // voxel factory
    public GameObject voxelFactory;
    // size of object pool
    public int voxelPoolSize = 20;
    // object pool
    public static List<GameObject> voxelPool = new List<GameObject>();

    void Start()
    {
        // input 
    }

    void Update()
    {
        // 1. if click mouse
        if (Input.GetButton("Fire1"))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();

            // 2. if mouse locates on the floor
            if (Physics.Raycast(ray, out hitInfo))
            {
                // 3. make voxel from voxelmaker
                GameObject voxel = Instantiate(voxelFactory);
                // 4. place voxel
                voxel.transform.position = hitInfo.point;
            }
        }
    }
}
