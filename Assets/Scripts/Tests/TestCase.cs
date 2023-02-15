using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class TestCase
{
    public IEnumerator TestGameManager()
    {
        GameObject gameObject = new GameObject();
        GameManager gameManager = gameObject.AddComponent<GameManager>();
        
        yield return new WaitForSeconds(0.5f);
        
        Assert.IsTrue(gameManager.IsTrue());
    }
}
