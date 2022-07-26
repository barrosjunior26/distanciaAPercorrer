namespace Exercicio24
{
    class distancia_em_km
    {
        public static void Main(String[] args)
        {
            /*24) Faça um algoritmo que pergunte a distância que um passageiro deseja
            percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para
            viagens até 200Km e R$0.45 para viagens mais longas.*/

            //Declaração de variáveis
            int opcao = 0;
            double passage = 0.50, passageII = 0.45;

            //Solicitando ao usuário a distancia que ele deseja percorrer
            Console.Write("Informe a distancia que você deseja percorrer: ");
            double distancia = double.Parse(Console.ReadLine());

            if(distancia <= 200)
            {
                double distanciaI = distancia * passage;
                Console.WriteLine("Distancia total: " + distancia + "Km\nValor da passagem para a distancia informada ficou no valor de R$" + distanciaI);
            }else if(distancia > 200)
            {
                double distanciaII = distancia * passage;
                Console.WriteLine("Distancia total: " + distancia + "Km\nValor da passagem para a distancia informada ficou no valor de R$" + distanciaII);
            }
            else
            {
                Console.WriteLine("Entrada de dados é inválida!");  
            }
        }
    }
}