using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnvironment
{
    private static GameEnvironment instance;

    private List<GameObject> turtles = new List<GameObject>();
    public List<GameObject> Turtles { get { return turtles; } }

    private List<GameObject> goals = new List<GameObject>();
    public List<GameObject> Goals { get { return goals; } }

    public static GameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
                instance.Goals.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            return instance;

        }
    }

    public GameObject GetRandomGoal()
    {
        int index = Random.Range(0, goals.Count);
        return goals[index];
    }

    public void AddTurtles(GameObject go)
    {
        turtles.Add(go);
    }

    public void RemoveTurtles(GameObject go)
    {
        int index = turtles.IndexOf(go);
        turtles.RemoveAt(index);
        GameObject.Destroy(go);
    }


}
