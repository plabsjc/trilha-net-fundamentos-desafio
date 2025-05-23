namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Carro> veiculos = new List<Carro>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o Modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano de fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Digite a cor do veículo: ");
            string cor = Console.ReadLine();
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            Carro carro= new Carro(modelo, marca, anoFabricacao, cor, placa);
            veiculos.Add(carro);
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*
            string placaProcurada = Console.ReadLine();
           
            bool existe = veiculos.Any(c => c.Placa.Equals(placaProcurada, StringComparison.OrdinalIgnoreCase));
            // Verifica se o veículo existe
            if (existe)
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTADO*
                int horas = 0;
                horas = int.Parse(Console.ReadLine());
                
                decimal valorTotal = precoInicial + precoPorHora * horas;
                

                // TODO: Remover a placa digitada da lista de veículos'
                // *IMPLEMENTADO*
                var removidos = veiculos.RemoveAll(c => c.Placa.Equals(placaProcurada, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"O veículo com a placa {placaProcurada} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*
                int contador = 1;
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                    if (contador >= veiculos.Count)
                    {
                        if (contador > 1)
                            Console.WriteLine($"O estacionamento possue {contador} carros cadastrados \n");
                        else
                        {
                            Console.WriteLine($"O estacionamento possue {contador} carro cadastrado \n");
                        }
                    }
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
