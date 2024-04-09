//Thread t1 = new Thread(new ParameterizedThreadStart(FuncionHilo));

//t1.Start(5);

//t1.Join();
//    Console.WriteLine("Hilo principal ha terminado");

//void FuncionHilo(object? parametro)
//{
//    int numero = (int)parametro;
//    Console.WriteLine($"Es un hilo secundario con parametro: {numero}");
//}
//--------------------------------------------------------------------------------------------------------------------------------------------------

// Thread t1 = new Thread(new ThreadStart(FuncionHilo)); 

// t1.Start(); 

//t1.Join(); 

//Console.WriteLine("Este es el hilo principal");

//void FuncionHilo()
//{
//  Console.WriteLine("Hilo secundario");
//}
//-----------------------------------------------------------------------------------------------------------------------------------------------

//int contador = 0; 

//object bloqueo = new object();

//// Crear vario hilos que incrementen el contador 
//Thread[] hilos = new Thread[5];

//for (int i = 0; i < 5; i++) 
//{
//    hilos[i] = new Thread(new ThreadStart(IncrementacionContador)); 
//    hilos[i].Start();   
//}

//foreach (Thread t in hilos)
//{
//    t.Join();
//}

//Console.WriteLine("Valor final del contador: " + contador);

//void IncrementacionContador()
//{
//    for (int i = 0; i < 1000; i++) 
//    {
//        lock(bloqueo) contador++;
//    } 
//}

//---------------------------------------------------------------------------------------------------------------------------------
using  Ejemplo01;

IFileRepository fileRepository = new ThreadSafeFileRepository("files");

// Cear hilos para realizar operaciones concurrentes de lectura y escritura de archivos 

Thread writeThread = new Thread(() => 
{
    for (int i = 0; i < 10; i++) 
    {
        string fileName = $"file_ {i}.txt";
        string content = $"Contenido del archivo {i}";
        fileRepository.SaveFile(new FileData 
        {
            FileName = fileName,
            Content = content
        });
        Console.WriteLine($"Archivo guardado: {fileName}");
        Thread.Sleep(100);
    }
}); 