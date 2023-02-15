using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestCase
{
    [UnityTest]
    public IEnumerator TestVersion1()
    {
        GameObject gameObject = new GameObject();
        GameManager gameManager = gameObject.AddComponent<GameManager>();
        
        yield return new WaitForSeconds(0.5f);
        
        Assert.IsTrue(gameManager.IsTrueVersion1());
    }
    
    [UnityTest]
    public IEnumerator TestVersion2()
    {
        GameObject  gameObject  = new GameObject();
        GameManager gameManager = gameObject.AddComponent<GameManager>();
        
        yield return new WaitForSeconds(0.5f);
        
        Assert.IsTrue(gameManager.IsTrueVersion2());
    }
}
