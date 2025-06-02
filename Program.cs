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
            Console.WriteLine("ingrese la operacion 1:valAbs 2:cuadrado 3:raiz 4:seno 5:coseno  6:ver parte entera");
            operacion = int.Parse(Console.ReadLine());

            string aux;
            double num3;
             while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux, out num3)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }

            switch (operacion)
            {
                case 1:valorAbs(num3);
                break;
                case 2:cuadrado(num3);
                break;
                case 3:raizC(num3);
                break;
                case 4:seno(num3);
                break;
                case 5:coseno(num3);
                break;
                case 6: parteEntera(num3);
                break;

            }
            double num4,num5;
            while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux,out num4)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
            while (true){
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux,out num5)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
            minYmax(num4,num5);


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

    static void valorAbs(double a){
        double resul = Math.Abs(a);
        Console.WriteLine("valor absoluto:"+resul);
    }
    static void cuadrado(double a){
        double resul = a*a;
        Console.WriteLine("al cuadrado:"+resul);
    }
    static void raizC(double a){
        double resul = Math.Sqrt(a);
        Console.WriteLine("raiz cuadrada:"+resul);
    }
    static void seno(double a){
        double radianes = a *(Math.PI /180);
        double resul = Math.Sin(radianes);
        Console.WriteLine("seno:"+resul);
    }
    static void coseno(double a){
        double rad = a*(Math.PI / 180);
        double resul = Math.Cos(rad);
        Console.WriteLine("coseno:"+resul);
    }
    static void parteEntera(double a){
        int resul = (int)a;//deja parte entera
        Console.WriteLine("Parte entera:"+resul);
    }
    static void minYmax(double a,double b){
        if (a>b)
        {
            Console.WriteLine("maximo:"+a+",minimo: "+b);
        }else
        {
            Console.WriteLine("maximo:"+b+",minimo: "+a);
        }
    }