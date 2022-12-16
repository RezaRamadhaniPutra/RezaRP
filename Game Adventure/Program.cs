using System;

namespace AdventureGame
{
    class program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Welcome to My Adventure Game");
            Console.WriteLine("What is your name");
            Newbie player = new Newbie();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+", ready to begin the game?[y/n]");
            string bReady = Console.ReadLine();
            if(bReady=="y"){
                Console.WriteLine(player.Name+" is entering the World...");
                Enemy Enemy1 = new Enemy("Dragon");
                Console.WriteLine(player.Name+" is encountering "+Enemy1.Name);
                Console.WriteLine(Enemy1.Name+" attacking you");
                Console.WriteLine("Choose your action");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Heavy Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !Enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        Console.WriteLine(player.Name+" is doing single Attack");
                        Enemy1.GetHit(player.AttackPower);
                        player.EXP += 0.3f;
                        Enemy1.Attack(Enemy1.AttackPower);
                        player.GetHit(Enemy1.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | Enemy Health : "+Enemy1.Health+"\n");
                        break;
                        case "2" :
                        player.Heavy();
                        player.EXP += 1.0f;
                        Enemy1.GetHit(player.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | Enemy Health : "+Enemy1.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored... ");
                        Enemy1.Attack(Enemy1.AttackPower);
                        player.GetHit(Enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        break;
                    }
                    continue;
                }
                
                Console.WriteLine(player.Name+" get " +player.EXP+" EXP point.");
            }
            else
            {
                Console.WriteLine("GoodBye.."); 
                Console.Read();
            }
        }
    }

    class Newbie
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float EXP { get; set; }
        Random rnd = new Random();

        public Newbie(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            EXP = 0f;
            Name = "Newbie";
        }

        public void Heavy(){
            if(SkillSlot > 0){
                Console.WriteLine("TAKE THAT!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }else{
                Console.WriteLine("You do not have energy!");
            }
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine("You are dead. Game Over!");
            IsDead = true;
        }      
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }
        
        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine(Name +" is dead");
            IsDead = true;
        }
    }
}
