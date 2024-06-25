Carro c1 = new Carro();
c1.velocidade = 20;

Moto m1 = new Moto();
m1.velocidade = 50;


//cria uma lista vazia de veiculos
List<Veiculo> veiculos = new List<Veiculo>();

//adicionar veiculos
veiculos.Add(c1);
veiculos.Add(m1);



//loop foreach

foreach(Veiculo veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
    

}
