using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Enemies;
using TextGame.Fighting;

namespace TextGame.Enemies
{
    public class Enemy
    {
        public Enemy(int Health, string Type, string Description, short PhysicalDamage, short ShadowDamage, short LightDamage, int VulnerabilityID, string VulnerabilityName)
        {
            this.Health = Health;
            this.Type = Type;
            this.Description = Description;
            this.Damage = new DamageTypes(PhysicalDamage, ShadowDamage, LightDamage);
            this.Vulnerabilities = new Vulnerability(VulnerabilityID, VulnerabilityName);
        }
        public int Health { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DamageTypes Damage { get; set; }
        public Vulnerability Vulnerabilities { get; set; }
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

