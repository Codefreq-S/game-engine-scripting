using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Week4
{
    public class Player : MonoBehaviour
    {
        /*public int health
        {
            get { return _health; }
            private set { _health = value; }
        }

        private int _health = 10;*/

        /*public int health
        {
            get;
            private set;
        }

        private void Awake()
        {
            health = 10;
        }*/

        [SerializeField] private int health = 10;
        [SerializeField]
        [Multiline(10)]
        private string name;

        [SerializeField] AudioClip attackSound;

        private AudioSource audio;

        private void Awake()
        {
            audio = GetComponent<AudioSource>();
        }
        public void Damage(int amt)
        {
            health -= amt;
        }

        private Enemy FindNewTarget()
        {
            Enemy[] enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
            int randomIndex = Random.Range(0, enemies.Length);
            return enemies[randomIndex];
        }

        public int GetHealth()
        {
            return health;
        }

        [ContextMenu("Attack")]
        void Attack()
        {
            Enemy target = FindNewTarget();
            target.Damage(10);
            //audio.Play();
            //audio.clip = attackSound;
            AudioManager.PlaySound(AudioManager.SoundType.ATTACK);
            //audio.PlayOneShot(attackSound);
        }
    }
}