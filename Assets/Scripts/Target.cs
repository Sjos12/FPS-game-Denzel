using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
    public class Target : MonoBehaviour
    {
        //health of zombie 
        public int health = 100;
        public bool dead = false;
        
        //time it takes for zombie to despawn after death.
        public float despawnDelay = 1f;

        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }

        //regulates health and damage taken
        public void TakeDamage(int amount)
        {
            
            health -= amount;
            
            GetComponent<Healthbar>().SetHealth(health);
            if (health <= 0f && dead == false)
            {
                //Destroy(gameObject);
                GameObject armature = gameObject.transform.GetChild(0).gameObject;
                //destroys hitbox inmediately after death. 
                GetComponent<CapsuleCollider>().enabled = false;
                Animator target_animator = armature.GetComponent<Animator>();

                target_animator.SetBool("isDead", true);

                GameObject zombieSpawner = GameObject.Find("Environment");
                zombieSpawner.GetComponent<SpawnZombie>().zombieAmount -= 1;
                dead = true;
            }
        }

        public void Die()
        {
            //destroys itself after animation is finished.
            Destroy(gameObject);    
        }

    }



