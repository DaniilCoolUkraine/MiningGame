using MiningGame.HealthSystem.Core;
using MiningGame.HealthSystem.Core.Interfaces;
using UnityEngine;

namespace MiningGame.GridSystem.Extendables
{
    public class DestructableCell : MonoBehaviourCell, IDamageable
    {
        [SerializeField] private int _maxHealth = 100;

        public Vector2Int Position { get; private set; }

        private Health _health;

        public override bool InitializeCell(int x, int y)
        {
            Position = new Vector2Int(x, y);
            _health = new Health(_maxHealth);

            gameObject.name = $"Cell {Position.x}|{Position.y}";
            
            return true;
        }
        
        public void Damage(int damage)
        {
            _health.RemoveHealth(damage);
        }
    }
}