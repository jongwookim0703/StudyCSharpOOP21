using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            //기본 생성자
            Console.WriteLine("야옹이 객체 생성 ");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

             Cat nero = new Cat
            {
                Name = "네로",
                Age = 65,
                Color = "Black"
            }; 
            
            nero.Meow();

            //파라미터를 만들어 입력할 수 있게 만들어줌
            Cat mimi = new Cat("미미", "노랑", 3);
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("은색", 10);
            noname.Name = "야오옹이";
            noname.Meow();
        }
    }
}
