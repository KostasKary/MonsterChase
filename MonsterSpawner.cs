using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] MonsterReference;
    public GameObject spawnedMonster;
    public Transform leftPos, rightPos;

    public int randomIndex;
    public int randomSide;

    float timer;

    void MonsterSpawn()
    {
        randomIndex = Random.Range(0, MonsterReference.Length);
        randomSide= Random.Range(0, 2);
        spawnedMonster = Instantiate(MonsterReference[randomIndex]);

        if (randomSide==0)
        {
            spawnedMonster.transform.position = leftPos.position;
            spawnedMonster.GetComponent<Enemies>().speed = Random.Range(4, 11);
        }
        else
        {
            spawnedMonster.transform.position = rightPos.position;
            spawnedMonster.GetComponent<Enemies>().speed = -Random.Range(4, 11);
            spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > Random.Range(1,5))
        {
            timer = 0f;
            MonsterSpawn();
        }
    }
}
