using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Enemy
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public float Damage { get; set; }
        public int Vulnerability { get; set; }

        public Enemy(string Type, string Description, float Damage, int Vulnerability)
        {
            this.Type = Type;
            this.Description = Description;
            this.Damage = Damage;
            this.Vulnerability = Vulnerability;
        }
        /*public Dictionary<int, string> Enemies;
        string[] EnemyDescriptions = new string[500];
        public Enemy()
        {
            this.Enemies = new Dictionary<int, string>();
            this.Enemies.Add(0, "Burglar");
            /*this.Enemies.Add(2, "Burglar");
            this.Enemies.Add(3, "Burglar");
            this.Enemies.Add(4, "Burglar");
            this.Enemies.Add(5, "Burglar");
            this.Enemies.Add(6, "Burglar"); 
        }
        public void SetEnemyDescriptions()
        {
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie.";
            EnemyDescriptions[0] = "A male human wearing a hoodie."; */
    }

    }

