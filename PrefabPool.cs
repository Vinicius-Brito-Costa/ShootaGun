using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PrefabPool : MonoBehaviour
{
    public bool SeguirPlayer = false;
    public GameObject ObjDoPlayer;
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    #region Instance
    public static Piscina Instance;
    private void Awake()
    {
        Instance = this;
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            if(pool.prefab.GetComponent<E_Controller>() != null)
            {
                pool.prefab.GetComponent<E_Controller>().QuemSeguir = ObjDoPlayer;
            }
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag, objectPool);
        }
    }
    #endregion

    public List<Pool> pools;

    public Dictionary<string, Queue<GameObject>> poolDictionary;

    void Start()
    {

    }
    public GameObject SpawnReusavel(string tag, Vector3 pos, Quaternion rota)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.Log("Warning");
            return null;
        }
        GameObject objReusado = poolDictionary[tag].Dequeue();
        objReusado.SetActive(true);
        objReusado.transform.position = pos;
        objReusado.transform.rotation = rota;
        
        poolDictionary[tag].Enqueue(objReusado);
        return objReusado;
    }
}
