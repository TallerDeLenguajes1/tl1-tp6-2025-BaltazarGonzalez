// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num;
        string entrada;
        Console.WriteLine("ingrese su numero");
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

        Console.WriteLine("ingrese la operacion 1:valAbs 2:cuadrado 3:raiz 4:seno 5:coseno 6:ver parte entera");
        int operacion = int.Parse(Console.ReadLine());

        string aux;
        double num1;

        while (true)
        {
            Console.WriteLine("ingrese un numero");
            aux = Console.ReadLine();
            if(double.TryParse(aux, out num1)){
                Console.WriteLine("numero valido");
                break;
            }else
            {
                Console.WriteLine("numero invalido");
            }
        }

        switch (operacion)
        {
            case 1:valorAbs(num1);
            break;
            case 2:cuadrado(num1);
            break;
            case 3:raizC(num1);
            break;
            case 4:seno(num1);
            break;
            case 5:coseno(num1);
            break;
            case 6: parteEntera(num1);
            break;
            
        }
        double num3,num4;
        while (true)
        {
            Console.WriteLine("ingrese un numero");
            aux = Console.ReadLine();
            if(double.TryParse(aux,out num3)){
                Console.WriteLine("numero valido");
                break;
            }else
            {
                Console.WriteLine("numero invalido");
            }
        }
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
        minYmax(num3,num4);

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