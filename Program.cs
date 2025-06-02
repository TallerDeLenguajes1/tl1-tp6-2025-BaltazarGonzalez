// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num;
        string entrada;
        Console.WriteLine("ingrese su numero para invertilo");
        entrada = Console.ReadLine();
        bool chequeo = false;
        
        if(int.TryParse(entrada, out num)){
            chequeo = true;
            
        }else{
            
            while(chequeo == false){
                Console.WriteLine("error ingrese un numero");
                entrada = Console.ReadLine();
                if(int.TryParse(entrada, out num)){
                    chequeo = true;
                 }
            }
        }
       Invertir(num);
    
    static void Invertir(int num){
        string invertido ="";
        
        while(num!=0){
            int dig = num%10;
            invertido += dig.ToString();
            num = num/10;
        }
        Console.WriteLine("su numero invertido: " + invertido);
    }
    
    Calculadora();

    static void Calculadora(){
        int continuar=1;

        while (continuar == 1)
        {
             Console.WriteLine ("Ingrese el num operacion que quiere 1:suma 2:resta 3:multiplicacion 4:division");
            int operacion;
            operacion = int.Parse(Console.ReadLine());
            string aux1;
            double num1;

            while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux1 = Console.ReadLine();
                if(double.TryParse(aux1, out num1)){//Intenta convertir a double
                    Console.WriteLine("numero valido");
                    break;//sale del bucle 
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
        
            string aux2;
            double num2;
        
            while (true)
            {
                Console.WriteLine("ingrese otro numero");
                aux2 = Console.ReadLine();
                if(double.TryParse(aux2, out num2)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
        
        
            switch(operacion){
             case 1:suma(num1,num2);
                break;
                case 2:resta(num1,num2);
                break;
                case 3:multiplica(num1,num2);
                break;
                case 4: dividir( num1, num2);
                break;
            }
            Console.WriteLine("desea hacer seguir calculando 1:si 0:no");
            continuar = int.Parse(Console.ReadLine());    
        }
       
    }
    static void suma(double a,double b){
        double resul = a+b;
        Console.WriteLine("resultado:"+resul);
    }
    static void resta(double a,double b){
        double resul = a-b;
        Console.WriteLine("resultado:"+resul);
    }
    static void multiplica(double a,double b){
        double resul = a*b;
        Console.WriteLine("resultado:"+resul);
    } 
    static void dividir(double a,double b){
        if(b == 0){
            Console.WriteLine("error no se puede dividir por 0");
            return;
        }
        double resul = a/b;
        Console.WriteLine("resultado:"+resul);
    }
