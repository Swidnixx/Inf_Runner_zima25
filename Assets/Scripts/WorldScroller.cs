using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform left, right;

    private void Update()
    {
        left.position += new Vector3( -speed , 0, 0) * Time.deltaTime;
        right.position += new Vector3( -speed , 0, 0) * Time.deltaTime;

        if(right.position.x <= 0)
        {
            left.position = right.position + new Vector3(21.2f, 0, 0);
            var tmp = left;
            left = right;
            right = tmp;
        }
    }
}
