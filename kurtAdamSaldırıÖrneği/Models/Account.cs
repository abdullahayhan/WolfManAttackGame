using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurtAdamSaldırıÖrneği.Modals
{
    class Account
    {
        public string userName { get; set; }
        public string race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }
        public int myDamage { get; set; }

        Random random = new Random();
        public void Attack() 
        {
            damage = 0;
            myDamage = 0;
            if (race=="Human")
            {
                damage += 5;
                myDamage += 5;
            }
            else
            {
                damage += 10;
                myDamage += 10;
            }
            switch (branch)
            {
                case "Warrior":
                    damage += 40;
                    myDamage += 40;
                    break;
                case "Mage":
                    damage += random.Next(30, 51);
                    myDamage += random.Next(30, 51);
                    break;
                case "Assasin":
                    damage += random.Next(10, 71);
                    myDamage += random.Next(10, 71);
                    break;
                case "Archer":
                    int number = random.Next(0, 1);
                    damage += number == 0 ? 5 : 60;
                    myDamage += number == 0 ? 5 : 60;
                    break;
            }
        }
    }
}
