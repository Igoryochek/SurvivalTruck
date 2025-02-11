using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Level
{
    public class ObjectPooler : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _pooledObjects;

        public List<GameObject> PooledObjects => _pooledObjects;

        public bool TryGetObject(out GameObject pooledObject)
        {
            pooledObject = _pooledObjects.FirstOrDefault(p => p.activeSelf == false);
            return pooledObject != null;
        }
    }
}