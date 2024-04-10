namespace ATV6_CJ3022528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio, i;

           
                    Console.WriteLine("Escolha um exercício: ");
                    Console.WriteLine("Digite 1 para 1");
                    Console.WriteLine("Digite 2 para 2");
                    Console.WriteLine("Digite 3 para 3");
                    Console.WriteLine("Digite 4 para 4");
                    Console.WriteLine("Digite 5 para 5");
                    Console.WriteLine("Digite 6 para 6");
                    Console.WriteLine("Digite 7 para 7");
                    exercicio = int.Parse(Console.ReadLine());

                    switch (exercicio)
                    {
                        case 1:
                            int n, contador = 0;

                            Console.WriteLine("Digite um número: ");
                            n = int.Parse(Console.ReadLine());

                            while (contador <= n)
                            {
                                Console.WriteLine(contador);
                                contador++;
                            }
                            break;
                        case 2:
                            int n1, contado = 0;

                            Console.WriteLine("Digite um número: ");
                            n1 = int.Parse(Console.ReadLine());

                            while (contado <= n1)
                            {
                                Console.WriteLine(contado);
                                contado++;
                            }
                            break;
                        case 3:
                            int n2, contad = 1000;

                            Console.WriteLine("Digite um número menor que 1000: ");
                            n2 = int.Parse(Console.ReadLine());

                            while (contad <= n2)
                            {
                                Console.WriteLine(contad);
                                contad--;
                            }

                            break;
                        case 4:
                    int n4, positivos = 0;
                    i = 0;

                            while (i < 10)
                            {
                                Console.WriteLine("Digite um número: ");
                                n4 = int.Parse(Console.ReadLine());

                                if (n4 > 0)
                                {
                                    positivos += n4;
                                    Console.WriteLine(n4);
                                }

                                if (positivos >= 200)
                                    break;
                            }

                            if (positivos < 200)
                                Console.WriteLine("A soma dos números positivos é menor que 200.");
                            break;

                        case 5:
                            int n5;
                             i = 1;
                            Console.WriteLine("Digite um número inteiro: ");
                            n5 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Divisores de ", n5, ":");

                            while (i <= n5)
                            {
                                if (n5 % i == 0)
                                {
                                    Console.WriteLine(i + " ");
                                }
                                i++;
                            }
                            Console.ReadLine();


                            break;


                    }







                }



}
        }
    
