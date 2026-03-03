using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Serialized Fields stateing custom variables
    [SerializeField] private float _maxTime = 1f;
    [SerializeField] private float _heightRange = 1f;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    //is used when start/played to actaully make the pipe ONCE
    private void Start()
    {
        SpawnPipe();
    }

    // spawns pipe on a timer based on the max timer variable above
    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }


    //handles the height and spawn position of the pipes randomly within a specific radius from the height ranger variable
    private void SpawnPipe()
    {
        Vector3 spawnpos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnpos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
