// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. 
//
// Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão ? 
//
// Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|       Programa para verificar se o aluno foi aprovado em função da sua frequência e média        |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 string nome;
 float frequencia, media;

    Console.Write($" Digite o nome do aluno: ");
    nome =  (Console.ReadLine()) .ToUpper() ;

    Console.WriteLine("");
    
    
    Console.Write($" Digite o percentual de frequência escolar do aluno:  ");
    frequencia = float.Parse (Console.ReadLine());
   
    Console.WriteLine("");
    
    
//*************************************** PROCESSAMENTO DE DADOS ******************************************//

//---------------------------------- VALIDAR APROVAÇÃO DO ALUNO -------------------------------------------//




 if (frequencia < 75 )

    {
        Console.Clear();
        Console.WriteLine($"ALUNO: {nome}  - FREQUÊNCIA: {frequencia}%");
        Console.WriteLine($"------------------------------------------------------------------");
        Console.WriteLine("************* O aluno  está reprovado por faltas! *******************");
        Console.WriteLine($"------------------------------------------------------------------"); 
    }

else

    Console.Write($" Digite o média escolar do aluno: ");
    media = float.Parse (Console.ReadLine());

    {
        Console.Clear();

        if ( media >= 7)
        {
        Console.WriteLine($"ALUNO: {nome}  - FREQUÊNCIA: {frequencia}% - MÉDIA: {media}" );
        Console.WriteLine($"------------------------------------------------------------------");
        Console.WriteLine("****************** O aluno  está aprovado! *************************");
        Console.WriteLine($"------------------------------------------------------------------"); 
        }

        else if ( media >= 4)

        {
        Console.WriteLine($"ALUNO: {nome}  - FREQUÊNCIA: {frequencia}% - MÉDIA: {media}" );
        Console.WriteLine($"------------------------------------------------------------------");
        Console.WriteLine("**************** O aluno está em recuperação! *********************");
        Console.WriteLine($"------------------------------------------------------------------");     
        }

        else
        {
        Console.WriteLine($"ALUNO: {nome}  - FREQUÊNCIA: {frequencia}% - MÉDIA: {media}" );
        Console.WriteLine($"------------------------------------------------------------------");
        Console.WriteLine("**************** O aluno está reprovado por Média! *****************");
        Console.WriteLine($"------------------------------------------------------------------");     
        }


    }


 Console.WriteLine("\nPressione qualquer tecla para sair...");

 Console.ReadKey();
