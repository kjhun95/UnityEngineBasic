using System;
using System.Reflection.Emit;

// 구조체 사용자 정의 자료형
// 멤버들을 캡슐화하는 자료형
// 멤버 변수, 프로퍼티, 함수 ..
//
// 선언 형태
// struct 이름
// {
//    멤버들 선언/정의
// }

namespace Structure
{
    public struct Stats
    {
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;

        public int GetCombatPwer()
        {
            return STR
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 클래스는 참조타입
            Player player = new Player();
            player.STR = 10;
            player.DEX = 10;
            player.INT = 10;
            player.LUK = 10;


            // 그러면은 언제 클래스를 쓰고 언제 구조체를 쓰냐?
            // 1. 멤버들의 크기 총합이 16 byte 이상일 때는 일반적으로 클래스를 씀
            //
            // 참조타입으로 값을 읽고 쓰는거 보다 값타입을 읽고 쓰는게 빠르다.
            // 하지만 16 byte를 초과할때는 레지스터가 두번 이상 값을 읽어야 하기 때문에
            // 값타입이어도 참조타입보다 느려진다.
            //
            // 2. 값을 쓰고 읽는것이 빈번하게 일어날 경우 (ex. 함수의 인자로 넘겨주는 횟수가 잦을 경우)
            // 구조체를 사용하는것이 효율적이다.


            // 구조체는 값타입
            Player_s player_s = new Player_s();
            enemy.Stats.STR = 10;
            enemy.Stats.DEX = 10;
            enemy.Stats.INT = 10;
            enemy.Stats.LUK = 10;
            Console.WriteLine($"적의 전투력이 {enemy.Stats.GetCombatPower() 입니다 !!");

            Player_s player s = new Player_s();
            Player_
        }
    }

    public class Player
    {
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;
    }

    public struct 

    public class Enemy
    {
        public Stats Stats;
    }
}
