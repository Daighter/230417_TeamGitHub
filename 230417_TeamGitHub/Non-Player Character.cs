using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Non_Player_Character
    {
        private string name;
        public Non_Player_Character(string name)
        {
            this.name = name;
        }
    }
    public class OldNpc : Non_Player_Character
    {
        public OldNpc(string name) : base(name)
        {
            string str = "허허허....";
            string str1 = "아이구...허리야...";
            string str2 = "누가 이 늙은이좀 도와줬으면 하는데...";
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

    }
    public class GirlNpc : Non_Player_Character
    {
        public GirlNpc(string name) : base(name)
        {
            string str = "꺄르륵!!";
            string str1 = "못보던 아저씨다~";
            string str2 = "아저씨는 어디서 왔어요?";
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

    }
    public class BoyNpc : Non_Player_Character
    {
        public BoyNpc(string name) : base(name)
        {
            string Boy = "거기서!";
            string Boy1 = "잡히기만 해봐!";
            string Boy2 = "저 아저씨는 누구지?";
            Console.WriteLine(Boy);
            Console.WriteLine(Boy1);
            Console.WriteLine(Boy2);
        }

    }
    public class WomanNpc : Non_Player_Character
    {
        public WomanNpc(string name) : base(name)
        {
            string str = "어디서 온 청년이지?";
            string str1 = "우리 마을은 무슨일로 왔어요?";
            string str2 = "이놈의 남편은 어디있는거야!?";
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

    }
}