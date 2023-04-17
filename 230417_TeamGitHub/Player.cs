using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Player
    {
        protected string name;
        public int hp;
        public int ap;
        public int mp;
        public int dp;

        public Player(string name, int hp, int ap, int mp,int dp)
        {
            this.name = name;
            this.hp = hp;
            this.ap = ap;
            this.mp = mp;
            this.dp = dp;
        }
        public void TrueDamage(int damage)
        {
            hp -= (damage - dp);
            Console.WriteLine($"{name}가 {(damage - dp)}의 피해를 받았다.");
        }
        // 플레이어가 피해를 입음
        public void Attack(int ap)
        {
            Console.WriteLine($"{name}가 {ap}의 피해를 입혔다");
        }
        // 플레이어의 공격
        public void Move()
        {
            Console.WriteLine($"{name}가 이동합니다.");
        }
        // 플레이어의 이동
        public void MagicAttack(int damage)
        {
            hp -= (damage + mp);
            Console.WriteLine($"{name}가 {(damage+mp)}의 마법 피해를 입혔다");

        }

        /*public void WeaponEquip(Weapon weapon)
        {
            Console.WriteLine($"플레이어가 {weapon}를 장착.");
            this.weapon = weapon;
            ap += weapon;
        }
        // 플레이어가 무기를 장착
        public void UnEquip(Weapon weapon)
        {
            Console.WriteLine($"플레이어가 {weapon}를 해제.");
            this.weapon = weapon;
            ap -= weapon;
        }
        // 플레이어가 무기를 해제.
        */
    }
}