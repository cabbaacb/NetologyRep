using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    public bool CubeTransform; //индикатор перемещения куба в инспекторе

    void Update()
    {
        if (CubeTransform)
        {
            transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }
    } 
}
