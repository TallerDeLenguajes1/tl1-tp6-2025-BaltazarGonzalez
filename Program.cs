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
    Console.WriteLine ("Ingrese el num operacion que quiere 1:suma 2:resta 3:multiplicacion 4:division");
        int operacion;
        operacion = int.Parse(Console.ReadLine());
        
        Console.WriteLine("ingrese un numero");
        int num1;
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("ingrese otro numero");
        int num2;
        num2 = int.Parse(Console.ReadLine());
        
        switch(operacion){
            case 1:suma(num1,num2);
            break;
            case 2:resta(num1,num2);
            break;
            case 3:multiplica(num1,num2);
            break;
            case 4: dividir((double) num1,(double) num2);
            break;
        }
        
    }
    static void suma(int a,int b){
        int resul = a+b;
        Console.WriteLine(""+resul);
    }
    static void resta(int a,int b){
        int resul = a-b;
        Console.WriteLine(""+resul);
    }
    static void multiplica(int a,int b){
        int resul = a*b;
        Console.WriteLine(""+resul);
    } 
    static void dividir(double a,double b){
        if(b == 0){
            Console.WriteLine("error no se puede dividir por 0");
            return;
        }
        double resul = a/b;
        Console.WriteLine(""+resul);
    }
