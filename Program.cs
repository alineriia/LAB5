using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*Створити абстрактний клас «Figure» з методами обчислення площі та периметра, а також
методом, що виводить інформацію про фігуру на екран. Створити похідні класи: Rectangle
(прямокутник), Circle (коло), Triangle (трикутник) зі своїми методами обчислення площі та периметра.
Створити масив n фігур і вивести повну інформацію про фігури на екран.
*/

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Rectangle[] r = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                r[i] = new Rectangle();
            }
            r[0].Input("rect1.txt");
            r[1].Input("rect2.txt");
            r[2].Input("rect3.txt");
            for (int i = 0; i < n; i++)
            {
                r[i].Output();
            }
            
            Circle[] c = new Circle[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = new Circle();
                
            }
            c[0].Input("circ1.txt");
            c[1].Input("circ2.txt");
            c[2].Input("circ3.txt");
            for (int i = 0; i < n; i++)
            {
                c[i].Output();
            }
            

            Triangle[] t = new Triangle[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = new Triangle();
                
            }
            t[0].Input("tria1.txt");
            t[1].Input("tria2.txt");
            t[2].Input("tria3.txt");
            for (int i = 0; i < n; i++)
            {
                t[i].Output();
            }
            
            Console.ReadKey();
        }
    }
}