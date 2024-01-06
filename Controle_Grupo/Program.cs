class Program
{ 
    public static void Main(string[] args)
    {
        string[] grupo = { "James", "Nathan", "Salomon", "Mayer", "Napoleão", "Wellington" };
        
        int soma = 0; 

        for (int i = 0; i < grupo.Length; i++)
        {
            if (grupo.Length > 7)
            {
                Console.WriteLine($"O grupo atingiu o número máximo de pessoas, por favor dirija-se ao próximo avião");
                break;
            }
            soma ++;
           
        }
        if (soma > 0)
        {
            Console.WriteLine($"Número de passageiros: {soma}");
            Console.WriteLine($"O grupo pode embarcar no avião");
        }

    }
}