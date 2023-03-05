internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio soma de par e impar em while

        int num=0;
        int somaPar=0;
        int somaImpar = 0;

        while (num < 1000)
        {
            Console.WriteLine("digite um numero e se quiser sair digite 1000: ");
            num = int.Parse(Console.ReadLine());

            if (num == 1000)
            {
                Console.WriteLine("saindo");
            }
            else if (num < 0)
            {
                Console.WriteLine("invalido");
            }
            else if(num%2==0)
            {
                somaPar = somaPar + num;
            }
            else if (num%2==1) 
            {
                somaImpar= somaImpar + num;
            }
        }
        Console.WriteLine("soma dos numeros pares: "+somaPar+"\nsoma dos numeros impares: "+somaImpar);
    }
}