using System.Linq;
using System.Collections.Generic;
using UnityEngine;

// Needs to filter entities for build bar

namespace Entities {
    [CreateAssetMenu(menuName = "Scriptables/Entities/EntityCollection")]

    public class EntityCollection : ScriptableObject {
        [SeriazlizeField] List<Entity> entities;

        public Entity GetEntity(string name) {
            Entity e = entities.Where(x => x.info.name == name).FirstorDefault();
            if (e != null) return e;
            Debug.LogWarning($"Warning! Entity with name: {name} was not found in collection.", this);
            return null;
        }

        public List<EntityCollection> GetEntities(string group) {
            List<Entity> e = entities.Where(x => x.info.group == group).ToList();
            if (e != null && e.Count > 0) return e;
            return null;
        }
    }
}