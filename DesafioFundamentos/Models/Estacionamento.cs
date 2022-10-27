namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        
        private  List<string> placa = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
        
            //Implementado!!!
            Console.WriteLine($"Digite a placa do vei�culo para estacionar:{ veiculos.Count }");

            veiculos.Add("veiculos");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do vei�culo para remover:");
            

             //Implementado!!!
            string placa = "";
            
            placa = Console.ReadLine();
            
            // Verifica se o ve�culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o vei�culo permaneceu estacionado:");

                         
                // Implementado!!!

                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                
                decimal valorTotal = 0; 
                valorTotal = (precoInicial + precoPorHora) * horas;

                //Implementado!!!

                veiculos.Remove(placa);

                Console.WriteLine($"O ve�culo {placa} foi removido e o pre�o total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse ve�culo n�o est� estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se h� ve�culos no estacionamento
            if (veiculos.Any())
            {
                
               
                Console.WriteLine("Os ve�culos estacionados s�o:");
                // Implementado

                foreach(string veiculo in veiculos) 
                {
                 Console.WriteLine(veiculo);   
                }
            }
            else
            {
                Console.WriteLine("N�o h� ve�culos estacionados.");
            }
        }
    }
}
