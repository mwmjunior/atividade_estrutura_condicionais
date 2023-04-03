// Escreva um programa que leia as medidas dos lados de um  triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno. 
//  Sendo que:    
// − Triângulo Equilátero: possui os 3 lados iguais.
// − Triângulo Isóscele: possui 2 lados iguais.
// − Triângulo Escaleno: possui 3 lados diferentes.



Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|                      Programa que informa o placar de um jogo de futebol                         |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

Console.WriteLine($"-------------------------------- Verificador de Triângulo --------------------------------\r\n");


//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 float lado_a, lado_b, lado_c;
 

    Console.WriteLine($"Digite o lado A do triângulo: ");
    lado_a = float.Parse (Console.ReadLine());

    Console.WriteLine($"Digite o lado B do triângulo: ");
    lado_b = float.Parse (Console.ReadLine());

    Console.WriteLine($"Digite o lado C do triângulo: ");
    lado_c = float.Parse (Console.ReadLine());


//*************************************** PROCESSAMENTO DE DADOS ******************************************//
   
   
 // Maior valor
  
    if ( lado_a + lado_b > lado_c && lado_a + lado_c > lado_b && lado_b + lado_c > lado_a)
         {
            Console.WriteLine($" Os lados informados formam um triangulo !");

            if(lado_a == lado_b && lado_a == lado_c)
                {
                Console.WriteLine($"O triângulo é equilátero ");
                }

            else if (lado_a == lado_b || lado_a == lado_c || lado_b == lado_c)
                {
                Console.WriteLine($"O triângulo é isósceles ");
                }
                
            else
                {
                Console.WriteLine($"O triângulo é escaleno ");
                }
         }

                 
    else
        {
            Console.WriteLine($"Os lados informados não formam um  !");
        }