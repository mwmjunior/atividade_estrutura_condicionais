// Programa que verifica a validade de uma senha fornecida pelo usuário, onde a senha válida é o número 1234.
//
// Devem ser impressas as seguintes mensagens:
//
// Caso a senha seja válida: “ACESSO PERMITIDO”;
// Caso a senha seja inválida: “ACESSO NEGADO”.


Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|             Programa para verificar se a senha digitada pelo usuario está correta                |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 float senha;
 
    Console.WriteLine($" Digite uma senha de 4 caracteres: ");
    senha = float.Parse (Console.ReadLine());

    
   
//*************************************** PROCESSAMENTO DE DADOS ******************************************//

//------------------------------------ VALIDAR SENHA --------------------------------------------------//
 
 if ( senha == 1234 )

    {
        Console.WriteLine($" A Senha está Correta !");
        await Task.Delay(5000);
        Console.WriteLine($" ACESSO  PERMITIDO ");
        
    }

else
    {
        Console.WriteLine($"A Senha está Icorreta !");
        await Task.Delay(5000);
        Console.WriteLine($" ACESSO  NEGADO ! ");
    
    }
 