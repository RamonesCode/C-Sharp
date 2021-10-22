using System;   // ===> IMPORTAÇÃO DE DEPENDÊNCIAS

namespace Course // ===> NAMESPACE DA CLASSE
{
    class Triangulo // ===> NOME DA CLASSE
    {
        public double A;                // ATRIBUTOS DA CLASSE 
        public double B;                // ===>  O PREFIXO "PUBLIC" INDICA QUE O ATRIBUTO OU MÉTODO PODE SER USADO EM OUTROS ARQUIVOS
        public double C;
        
        public double Area()    // ===> NOME DO MÉTODO
                          // ===>  "()" REPRESENTA A LISTA DE PARÂMETROS[dados] DO MÉTODO, QUE NESSE CASO AQUI ESTÁ USANDO APENAS OS PARAMETROS DA CLASSE (ATRIBUTOS ->A,B,C)
        {
            // ===> O "DOUBLE" É O TIPO DE DADO QUE O MÉTODO RETORNA ( SE O MÉTODO NÃO RETORNA NADA, USA-SE O "VOID")
            double p = (A + B + C) / 2.0;                           
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));  // ==> CORPO DO MÉTODO   
        }
    }
}