// Programa recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, e se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|                      Programa que informa o placar de um jogo de futebol                         |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 int gols_time_a, gols_time_b;
 

    Console.WriteLine($"Digite a quantidade de gols do time A: ");
    gols_time_a = int.Parse (Console.ReadLine());

    Console.WriteLine($"Digite a quantidade de gols do time B: ");
    gols_time_b = int.Parse (Console.ReadLine());


//*************************************** PROCESSAMENTO DE DADOS ******************************************//
   
   
 // Maior valor
  
    if (gols_time_a == gols_time_b)
         {
            Console.WriteLine($" Houve um empate no jogo ");
         }

        else
            if(gols_time_a > gols_time_b)
                {
                Console.WriteLine($"O time A é o vencedor");
                }
                
            else
                {
                Console.WriteLine($"O time B é o vencedor");
                }
                
                