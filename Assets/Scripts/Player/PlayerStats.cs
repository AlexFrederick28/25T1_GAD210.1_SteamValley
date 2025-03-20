using JetBrains.Annotations;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    public float maxHealth;
    [SerializeField] private float speed;
    [SerializeField] private float attack;
}
