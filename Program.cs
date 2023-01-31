namespace lab8
{
    class Family
    {
      public interface IHomo
        {
           public void Breakfast();
           public void Dinner();
           public void Supper();
        }
        public abstract class Homo_sapiens
        {
        }
        public class Men : Homo_sapiens, IHomo
        {
            public void Breakfast()
            {
                Console.WriteLine("Мужчина:Завтрака хочеца");
            }
            public void Dinner()
            {
                Console.WriteLine("Мужчина:Обеда хочеца");
            }
            public void Supper() 
            {
                Console.WriteLine("Мужчина:Ужина хочеца");
            }
        }
        public class Woman : Homo_sapiens, IHomo
        {
            public void Breakfast() { Console.WriteLine("Женщина:Хочу завтракать"); }
            public void Dinner() { Console.WriteLine("Женщина:Хочу обедать"); }
            public void Supper() { Console.WriteLine("Женщина:Хочу ужинать"); }
        }
        public class Child : Homo_sapiens, IHomo
        {
            public void Breakfast() { Console.WriteLine("Ребенок:Хачу зафтрак"); }
            public void Dinner() { Console.WriteLine("Ребенок:Хачу абед"); }
            public void Supper() { Console.WriteLine("Ребенок:Хачу ужын"); }
        }


        public static void Main()
        {
            IHomo woman = new Woman(), men = new Men(), child = new Child();
            
           
            for (int i = 0; i < 5; i++)
            {
                string question = Console.ReadLine().ToLower();
                string breakfast = "завтрак", dinner = "обед", supper = "ужин";
                if (question.Contains(breakfast))
                {
                    men.Breakfast();
                    woman.Breakfast();
                    child.Breakfast();

                }
                else if (question.Contains(dinner))
                {
                    men.Dinner();
                    woman.Dinner();
                    child.Dinner();
                }
                else if (question.Contains(supper))
                {
                    men.Supper();
                    woman.Supper();
                    child.Supper();
                }
                else
                {
                   Console.WriteLine("Может сформулируете вопрос по другому?");
                }
                }
            }
        }
    }
