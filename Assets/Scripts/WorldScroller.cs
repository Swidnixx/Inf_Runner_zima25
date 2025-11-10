using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform left, right;

    public Transform[] worldSegments;

    private void Update()
    {
        left.position += new Vector3( -speed , 0, 0) * Time.deltaTime;
        right.position += new Vector3( -speed , 0, 0) * Time.deltaTime;

        if(right.position.x <= 0)
        {
            Destroy(left.gameObject);
            left = right;
            right = SpawnRandomSegment();
            right.position = left.position + new Vector3(21.2f, 0, 0);
        }
    }

    Transform SpawnRandomSegment()
    {
        int numer = Random.Range(0, worldSegments.Length);
        Transform prefab = worldSegments[numer];
        return Instantiate(prefab);
    }
}
