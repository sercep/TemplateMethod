using System;

namespace ConsoleApp1
{
  abstract class University
  {
    public void Learn()
    {
      Enter();
      Study();
      WritingThesis();
      GetDocument();
    }
    public abstract void Enter();
    public abstract void Study();
    public virtual void WritingThesis()
    {
      Console.WriteLine("Написание дипломной работы");
    }
    public abstract void GetDocument();
  }

  class Bacl : University
  {
    public override void Enter()
    {
      Console.WriteLine("Сдача ЕГЭ и поступление на бакалавриат");
    }

    public override void Study()
    {
      Console.WriteLine("Обучение на бакалавриате");
    }

    public override void GetDocument()
    {
      Console.WriteLine("Получение диплома бакалавра");
    }
  }

  class Magistr : University
  {
    public override void Enter()
    {
      Console.WriteLine("Сдача вступительных экзаменов и поступление на магистратуру");
    }

    public override void Study()
    {
      Console.WriteLine("Обучение на магистратуре");
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
      Bacl bacl = new Bacl();
      bacl.Learn();
      Magistr magistr = new Magistr();
      magistr.Learn();
      Console.Read();
    }
  }
}
