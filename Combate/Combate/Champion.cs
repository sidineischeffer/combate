using System;

namespace Combate {
    class Champion {

    
            public string name { get; private set; }
            public int life { get; private set; }
            public int attack { get; private set; }
            public int armor { get; private set; }

            public Champion(string name, int life, int attack, int armor) {
                name = name;
                life = life;
                attack = attack;
                armor = armor;
            }

            public void takeDamage(int attack) {
                int damage = attack - armor;
                if (damage < 1) {
                    damage = 1;
                }
                life -= damage;
                if (life < 0) {
                    life = 0;
                }
            }

            public string status() {
                if (life > 0) {
                    return $"{name} tem {life} de vida.";
                }
                else {
                    return $"{name} morreu.";
                }
            }
        }
    }
