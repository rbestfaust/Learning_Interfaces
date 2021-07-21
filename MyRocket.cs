using System;

namespace Myrocket
{
    class MyRocket
    {
        static void Main(string[] args)
        {
            Bolid one = new Bolid();
            one.New_corpus = new Korpus();
            one.New_dviglo = new Auto_dvigok();
            one.New_corpus.Name = "Shkoda";

            Bolid two = new Bolid();
            two.New_corpus = new Korpus();
            two.New_corpus.Name = "Audi A6";


            



            Console.WriteLine($"Korpus name : {one.New_corpus.Name}\n Korpus weight :{one.New_corpus.Weight}" +
                $" \n Dviglo weight :{one.New_dviglo.Weight}\n" +
                $" Dviglo name : {one.New_dviglo.Name} \n " +
                $"Total weight = {one.New_corpus.Weight + one.New_dviglo.Weight} \n");


            one.New_dviglo = new Moto_dvigok();
            one.New_corpus.Name = "Yamaha";

            Console.WriteLine("Updated");


            Console.WriteLine($"Korpus name : {one.New_corpus.Name}\n Korpus weight :{one.New_corpus.Weight}" +
                $" \n Dviglo weight :{one.New_dviglo.Weight}\n" +
                $" Dviglo name : {one.New_dviglo.Name} \n " +
                $"Total weight = {one.New_corpus.Weight + one.New_dviglo.Weight} \n");

            one.New_dviglo = new Audi_dvijok();
            one.New_corpus.Name = "Audi A6";


            Console.WriteLine("Updated");


            Console.WriteLine($"Korpus name : {one.New_corpus.Name}\n Korpus weight :{one.New_corpus.Weight}" +
                $" \n Dviglo weight :{one.New_dviglo.Weight}\n" +
                $" Dviglo name : {one.New_dviglo.Name} \n " +
                $"Total weight = {one.New_corpus.Weight + one.New_dviglo.Weight} \n");






        }
    }
}
