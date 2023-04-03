// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia e, R$0,25 cada, se forem compradas pelo menos uma dúzia. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.


Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|             Programa para calcular o custo da maça em função da quantidade comprada              |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 int quantidade_de_macas;
 float total_da_compra, desconto = 0;
 
    Console.WriteLine($" Digite a quantidade de maçãs que deseja comprar: ");
    quantidade_de_macas = int.Parse (Console.ReadLine());
    Console.WriteLine("");
    

//*************************************** PROCESSAMENTO DE DADOS ******************************************//

//------------------------------------ CALCULAR PREÇO --------------------------------------------------//
 
 if ( quantidade_de_macas >= 12 )

    {
        total_da_compra = quantidade_de_macas * 0.25f ; 
        desconto = quantidade_de_macas * 0.05f;

        Console.WriteLine($"------------------------------------------------------------------");
        Console.WriteLine("*************************** MAÇÃ *********************************");
        Console.WriteLine($"  ATENÇÃO: PRODUTO COM DESCONTO COMPRANDO 12 OU MAIS UNIDADES !     ");
        Console.WriteLine($"------------------------------------------------------------------\r\n");
        
    }

else
    {
        total_da_compra = quantidade_de_macas * 0.30f;
    }

Console.WriteLine($"Quantidade total: { quantidade_de_macas} unidades");
Console.WriteLine($"Custo total da compra foi de R$: {string.Format("{0:C2}", total_da_compra)} reais");
Console.WriteLine($"Desconto de R$: {string.Format("{0:C2}", desconto)} reais");

