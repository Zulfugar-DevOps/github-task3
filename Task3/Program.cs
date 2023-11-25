namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Task 3.1 -  4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
        //Example1: 3333 = 73338

            string N1 = "4444";

            Console.WriteLine(N1);

            Console.WriteLine(7 + N1 + 8);

            //Task 3.1 ve ya

            int N2 = 4444;

            N2 = 740004 + 4444;

            Console.WriteLine(N2);



            //Task 3.2 - 3 reqemli eded verilib.
            //Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;

            string N3 = "888";

            Console.WriteLine(N3);

            Console.WriteLine(888 + N3);

            //Task 3.2 ve ya

            int N4 = 888;

            N4 = N4 + 888000;

            Console.WriteLine(N4);


            //Task 3.3 - 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

            int N5 = 10000;
            
            double faiz18 = 18;

            double faiz3 = 3;
           
            double cavab1 = N5 * (faiz18 / 100);

            double cavab2 = N5 * (faiz3 / 100);

            Console.WriteLine($"5 reqemli ededin (10.000) 18 faizi {cavab1}");
            Console.WriteLine($"5 reqemli ededin (10.000) 3 faizi {cavab2}");

            //Task 3.4 - 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

            int N6 = 500;

            Console.WriteLine(N6);

            N6 = N6 + 4507;

            Console.WriteLine(N6);

            double faiz7 = 7;

            double cavab3 = N6 * (faiz7 / 100);

            Console.WriteLine($"Cavabin 7 faizi {cavab3}");

            //Task 3.5 - 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi ,
            //axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            int N7 = 2500;

            Console.WriteLine(N7);  

            N7 = N7 + 4247544;

            Console.WriteLine(N7);

            double faiz44 = 44;

            double cavab4 = N7 * (faiz44 / 100); 

            Console.WriteLine($"Alinan cavabin (4250044) 44 faizi {cavab4}");

            //Task 3.6 - 4 reqemli eded verilib.
            //Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

            int N8 = 2000;

            Console.WriteLine(N8);

            double faiz20 = 20;

            double cavab5 = N5 * (faiz20 / 100);

            Console.WriteLine($"Ededin 20 faizi {cavab5}");

            double faiz10 = 10;

            double cavab6 = cavab5 * (faiz10 / 100);

            Console.WriteLine($"Cavabin 10 faizi {cavab6}");

            double kv = cavab6 * cavab6;

            Console.WriteLine($"Alinin cavabin kvadradi {kv}");


            //Task 3.7 - 2 dene 5 reqemli eded verilib.
            //Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

            int N9 = 12500;

            int N10 = 28300;

            double cavab7 = N9 + N10;

            Console.WriteLine(N9); 

            Console.WriteLine(N10);

            Console.WriteLine($"Ededlerin cemi {cavab7}");

            double cavab8 = cavab7 + 5367205;

            Console.WriteLine(cavab8);

            double faiz5 = 5;

            double cavab9 = cavab8 * (faiz5 / 100);

            Console.WriteLine($"Neticenin 5 faizi {cavab9}");

            //Task 3.8 - 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            //I ededin 4 % -ni tap.
            //Sonra II ededin 9 % ni tap.
            //Sonra Cavalari toplayib 10 % ni tap.

            int N11 = 1866;

            int N12 = 8419848;

            Console.WriteLine (N11);

            Console.WriteLine (N12);

            double faiz4 = 4;

            double cavab10 = N11 * (faiz4 / 100);

            Console.WriteLine($"1ci ededin 4 faizi {cavab10}");

            double faiz9 = 9;

            double cavab11 = N12 * (faiz9 / 100);

            Console.WriteLine($"2ci ededin 9 faizi {cavab11}");

            double cavab12 = cavab10 + cavab11;

            double cavab13 = cavab12 * (faiz10 / 100);

            Console.WriteLine($"Toplanan cavablarin 10 faizi {cavab13}");

            //Task 3.9 - 3 dene 6 reqemli eded verilib.
            //Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.

            int N13 = 787197;

            int N14 = 156748;

            int N15 = 525630;

            double cavab14 = N13 * (faiz5 / 100);
            Console.WriteLine(cavab14);

            double cavab15 = N14 * (faiz5 / 100);
            Console.WriteLine($"{cavab15} sifirlar bilmirem niye ele oldu");

            double cavab16 = N15 * (faiz5 / 100);
            Console.WriteLine(cavab16);

            double cavab17 = cavab14 + cavab15 + cavab16;
            Console.WriteLine($"10 faizlerinin neticesinin toplusu {cavab17}");

            double cavab18 = cavab17 * (faiz10 / 100);
            Console.WriteLine($"Alinan cavabin 10 faizi {cavab18}");

            //Task 3.10 - 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel

            //Artiq N-leri ve Cavab-lari qarishdirmaq vaxtidir :)

            int numb1 = 8246;

            int numb2 = 6352;

            int numb3 = 4453;

            double faiz1 = 1;

            double nf1 = numb1 * (faiz1 / 100);

            Console.WriteLine($"1-ci ededin 1 faizi {nf1}");

            double faiz2 = 2;

            double nf2 = numb2 * (faiz2 / 100);

            Console.WriteLine($"2-ci ededin 2 faizi {nf2}");

            double nf3 = numb3 * (faiz3 / 100);

            Console.WriteLine($"3-ci ededin 3 faizi {nf3}");

            double nn1 = nf1 - nf2 - nf3;

            Console.WriteLine($"Neticelerin bir-birinden cixilmasi {nn1}");

            double nf4 = numb3 * (faiz7 / 100);

            Console.WriteLine($"3-cu ededin 7 faizi {nf4}");

            double nn2 = nn1 + nf4;

            Console.WriteLine($"Alinan cavabin ustune 3-cu ededin 7 faizi gelerse {nn2}");

            Console.ReadKey();  
            
           

          

















































        }
    }
}