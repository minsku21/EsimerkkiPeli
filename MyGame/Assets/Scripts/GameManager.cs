using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    List<Enemy> enemies = new List<Enemy>();
    
    // Start is called before the first frame update
    void Start()
    {
        enemies.AddRange(FindObjectsOfType<Enemy>());
        Debug.Log("Vihollisia on " + enemies.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RemoveEnemy(Enemy enemy)
    {
        if (enemies.Contains(enemy))
        {
            enemies.Remove(enemy);
            Debug.Log("Vihollisia on " + enemies.Count);
        }
        if (enemies.Count==0)
        {
            Debug.Log("All enemys are destroied");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
