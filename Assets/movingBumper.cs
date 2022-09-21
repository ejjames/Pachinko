using UnityEngine;

// Transform.Rotate example
//
// Two cubes are created.  One (red) is rendered using Space.Self.  The
// other (green) uses Space.World.  The rotation is controlled using xAngle,
// yAngle and zAngle. Over time, the cubes rotate differently.

public class movingBumper : MonoBehaviour
{
    float speed = 100.0f;

    void Awake()
    {

    }

    void Update()
    {
      transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}