using UnityEngine;
namespace Game{
public class GroundSpawner1 : MonoBehaviour {

    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile (bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnItems) {
            temp.GetComponent<GroundTile>().SpawnObstacle();
        }
    }

    private void Start () {
        for (int i = 0; i < 50; i++) {
            if (i < 1) {
                SpawnTile(false);
                
            } else {
                SpawnTile(true);
            }
        }
    }
}
}