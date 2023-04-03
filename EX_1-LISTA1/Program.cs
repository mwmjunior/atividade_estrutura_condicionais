


    Console.WriteLine($"Informe o salário recebido");
    float salario_recebido= float.Parse (Console.ReadLine());

    Console.WriteLine($"Infome o total gasto");
    float total_gasto = float.Parse  (Console.ReadLine());
    

   float orcamento = (salario_recebido - total_gasto) ;

   if (orcamento>0)
 {
    Console.WriteLine($"Gastos dentro do orçamento");    
 }

  else
 {
     Console.WriteLine($"Orçamento estourado");    
 }

