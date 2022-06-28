/*
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
- void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. 
    Potete prendere quella fatta in classe questa mattina
- int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
- int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, 
    e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
- int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
- Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e 
    verificare che sia rimasto [2, 6, 7, 5, 3, 9])
- Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati
BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, 
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente. 
 
*/
namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // functions

            /*
            void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. 
            Potete prendere quella fatta in classe questa mattina 
            */

            void PrintArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if(i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
            }
            /*
            int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
            */

            int Sqaure(int number)
            {
                return number * number;
            }

            /*
                int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, 
                e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
            */

            int[ ] RaiseArrayToSquare(int[] array)
            {
                int[] clonedArray = (int[])array.Clone();
                for (int i = 0; i < clonedArray.Length; i++)
                {
                    clonedArray[i] = Sqaure(array[i]);
                }

                return clonedArray;
            }

            /*
            int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            */

            int sumArrayElements(int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                return sum;
            }

            // end functions

            //program

            /*
                Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
                - Stampare l’array di numeri fornito a video
                - Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e 
                    verificare che sia rimasto [2, 6, 7, 5, 3, 9])
                - Stampare la somma di tutti i numeri
                - Stampare la somma di tutti i numeri elevati al quadrati
            */

            Console.Write("Inserire il numero di elementi che vuoi nell'array: ");
            int userInput = Int32.Parse(Console.ReadLine());


            int[] numbersArray = new int[userInput];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write("Inserire {0}° dell'array: ", i);
                numbersArray[i] = Int32.Parse(Console.ReadLine());  
            }



            PrintArray(numbersArray);

            Console.WriteLine();
            int[] squaredArray = RaiseArrayToSquare(numbersArray);

            PrintArray(squaredArray);

            Console.WriteLine("\nAncestor Array");

            PrintArray(numbersArray);

            int sumStanardArrayElements = sumArrayElements(numbersArray);
            Console.WriteLine("\nSomma Array: {0}", sumStanardArrayElements);
            int sumSquaredArrayElements = sumArrayElements(squaredArray);
            Console.WriteLine("Somma Array: {0}", sumSquaredArrayElements);

            /*
                BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, 
                ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
                e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente. 
            */
        }
    }
}