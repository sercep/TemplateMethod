using System;

namespace ConsoleApp1
{
  abstract class Education
  {
    public void Learn()
    {
      Enter();
      Study();
      PassExams();
      GetDocument();
    }
    public abstract void Enter();
    public virtual void Study()
    {
      Console.WriteLine("Обучение в  " + GetType().Name);
    }
    public abstract void PassExams();
    public abstract void GetDocument();
  }
  class Liceum : Education
  {
    public override void Enter()
    {
      Console.WriteLine("Поступление в лицей");
    }
    public override void PassExams()
    {
      Console.WriteLine("Сдача ЕГЭ");
    }
    public override void GetDocument()
    {
      Console.WriteLine("Получение аттестата");
    }
  }
  class Bacalavriat : Education
  {
    public override void Enter()
    {
      Console.WriteLine("Сдача ЕГЭ и поступление на бакалавриат");
    }
    public override void PassExams()
    {
      Console.WriteLine("Написание и защита ВКР");
    }
    public override void GetDocument()
    {
      Console.WriteLine("Получение диплома бакалавра");
    }
  }

  class Magistratura : Education
  {
    public override void Enter()
    {
      Console.WriteLine("Сдача вступительных экзаменов и поступление на магистратуру");
    }
    public override void PassExams()
    {
      Console.WriteLine("Написание и защита магистрской диссертации");
    }

    public override void GetDocument()
    {
      Console.WriteLine("Получние диплома магистратуры");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Liceum liceum = new Liceum();
      liceum.Learn();
      Bacalavriat bacalavriat = new Bacalavriat();
      bacalavriat.Learn();
      Magistratura magistratura = new Magistratura();
      magistratura.Learn();
      Console.Read();
    }
  }
}
